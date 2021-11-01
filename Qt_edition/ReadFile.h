#ifndef READFILE_H
#define READFILE_H

#include <iostream>
#include <fstream>
#include <string>
#include <vector>
using namespace std;

class ReadFile
{
public:
    /*Constructor*/
    ReadFile();

    /*Choose working path*/
    void selectTarget(int);

    /*To Input File*/
    void appendToWorking(string);

    /*Change File Dictionary*/
    void setRootRepo(string);

    void refreshWorking();

    /*simple accessor*/
    string getValidPath();
    string getChart();
    string getWorkingCod();
    vector<string> getLegiValidPath();
    string getRootRepo();


private:
    string workingPath;
    string workingDoc;
    vector<string> validPath;
    string rootRepo;

    void saveToWorking();
    int lengthFind(string, int);
    int numChange(string s, int num_start, int len);
};

#endif // READFILE_H
