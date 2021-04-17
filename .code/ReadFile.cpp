#include "ReadFile.h"
using namespace std;

// Parsing file
ReadFile::ReadFile()
{
    // Add valid path to the private member
    string years[4] = {"2020", "2021", "2022", "2023"};
    string month[12] = {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"};


    // Include root dir
    ifstream root_input;
    root_input.open("RootRepo.txt", ios::in);

    string input_repo = "";
    getline(root_input, input_repo);


    this->rootRepo = input_repo;

    for(int y=3; y>=0; y--){
        for(int m=11; m>=0; m--){
            string file_path_name = years[y] + '_' + month[m] + ".txt";
            string file_path = rootRepo + file_path_name;

            ifstream test_exit;
            test_exit.open(file_path);

            if (test_exit){
                this->validPath.push_back(file_path_name);
            }

            test_exit.close();
        }
    }

    //root_input.close();
}

void ReadFile::selectTarget(int index){
    this->workingDoc = "";
    this->workingPath = rootRepo + validPath[index];

    ifstream working_input;
    working_input.open(this->workingPath, ios::in);

    string eat_input;
    while(getline(working_input, eat_input)){
        this->workingDoc += eat_input + "\n";
    }

    workingDoc[-1] = '\0';

    working_input.close();
}

void ReadFile::appendToWorking(string app){
    this->workingDoc += app;
    this->saveToWorking();
}

void ReadFile::refreshWorking()
{
    this->workingDoc = "";

    ifstream working_input;
    working_input.open(this->workingPath, ios::in);

    string eat_input;
    while(getline(working_input, eat_input)){
        this->workingDoc += eat_input + "\n";
    }

    workingDoc[-1] = '\0';
}



/*getter*/
string ReadFile::getValidPath(){
    string output;

    for (int i=0; i<this->validPath.size(); i++){
        output += "("+ to_string(i+1) +") " + this->validPath[i] + '\n';
    }

    return output;
}

string ReadFile::getChart(){
    string cri_com = "$", cri_uncom = "&", output;
    int pos = 0, pos_com[200] = {}, ipc = 0, pos_uncom[200] = {}, ipuc = 0;
    int com_sum = 0, uncom_sum = 0;

    // count the common chart
    while((pos = this->workingDoc.find(cri_com, pos)) != string::npos){
        pos_com[ipc++] = pos;
        pos++;
    }

    for(int i=0; i<ipc; i++){
        int len, chart;
        len = lengthFind(this->workingDoc, pos_com[i]);
        chart = numChange(this->workingDoc, pos_com[i]+1, len);
        com_sum += chart;
    }
    if(com_sum != 0){
        output += "Common sum is: " + to_string(com_sum) + '\n';
    }


    // count the uncommon chart
    pos = 0;

    while((pos = this->workingDoc.find(cri_uncom, pos)) != string::npos){
        pos_uncom[ipuc++] = pos;
        pos++;
    }

    for(int i=0; i<ipuc; i++){
        int len, chart;
        len = lengthFind(this->workingDoc, pos_uncom[i]);
        chart = numChange(this->workingDoc, pos_uncom[i]+1, len);
        uncom_sum += chart;
    }
    if(uncom_sum != 0){
       output += "Uncommon char is: " + to_string(uncom_sum) + '\n';
    }

    output += "Total sum is: " + to_string(com_sum + uncom_sum);

    return output;
}

string ReadFile::getWorkingCod()
{
    return this->workingDoc;
}

vector<string> ReadFile::getLegiValidPath()
{
    return this->validPath;
}

string ReadFile::getRootRepo()
{
    return this->rootRepo;
}

// Write in, refresh to new dir
void ReadFile::setRootRepo(string path)
{
    ofstream root_out;
    root_out.open("RootRepo.txt", ios::out);
    root_out << path;
    root_out.close();

    this->rootRepo = path;

    string years[4] = {"2020", "2021", "2022", "2023"};
    string month[12] = {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"};

    this->validPath.clear();
    this->workingDoc.clear();
    this->workingPath.clear();

    for(int y=3; y>=0; y--){
        for(int m=11; m>=0; m--){
            string file_path_name = years[y] + '_' + month[m] + ".txt";
            string file_path = rootRepo + file_path_name;

            ifstream test_exit;
            test_exit.open(file_path);

            if (test_exit){
                this->validPath.push_back(file_path_name);
            }

            test_exit.close();
        }
    }
}


void ReadFile::saveToWorking(){
    ofstream working_output;
    working_output.open(this->workingPath, ios::out);

    working_output << this->workingDoc;

    working_output.close();
}

int ReadFile::lengthFind(string s, int start){
    int len = 0;
    for(int i=start; s[i] != ' ' && s[i] != '\n' ; i++, len++);
    return len-1;
}

int ReadFile::numChange(string s, int num_start, int len){
    int num = 0;
    int numbers[6] = {}, inumbers = 0;
    for(int i=num_start; i<num_start+len; i++){
        numbers[inumbers++] = s[i] - '0';
    }


    for(int i=len-1, k=1; i>=0; i--, k*=10){
        num += numbers[i]*k;
    }

    return num;
}
