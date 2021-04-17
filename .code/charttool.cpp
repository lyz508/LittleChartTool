#include "charttool.h"
#include "ui_charttool.h"

ChartTool::ChartTool(QWidget *parent)
    : QMainWindow(parent)
    , ui(new Ui::ChartTool)
    , r(new ReadFile)
{
    ui->setupUi(this);
    ui->txtBrowserOpen->setText(s2q(this->r->getValidPath()));
}

ChartTool::~ChartTool()
{
    delete ui;
}

QString ChartTool::s2q(const string &s) {
    return QString(QString::fromLocal8Bit( s.c_str()));
}

string ChartTool::q2s(const QString &s) {
    return string ((const char *)s.toLocal8Bit());
}

void ChartTool::on_btnValidPush_clicked()
{
    if (ui->edtOpenFileInput->text() == ""){
        ui->edtOpenFileInput->setText("輸點啥");
    }
    else{
        QString selection = ui->edtOpenFileInput->text();
        int choice;

        string s_selec = q2s(selection), judge_cmd = s_selec.substr(0, 3);


        if (judge_cmd == "set"){
            string cmd = s_selec.substr(4, 100);
            r->setRootRepo(cmd);
            ui->txtBrowserOpen->setText(s2q(r->getValidPath()));
            ui->edtOpenFileInput->setText("");
        }
        else if (!selection.toInt()){
            ui->edtOpenFileInput->setText("Non valid Input!");
        }
        else{
            choice = ui->edtOpenFileInput->text().toInt();
            choice -= 1;

            vector<string> forSizeCount = r->getLegiValidPath();

            if (choice >= forSizeCount.size() || choice < 0){
                ui->edtOpenFileInput->setText("Non valid Input!");
            }
            else{
                this->r = new ReadFile();
                this->r->selectTarget(choice);

                string chart_count = r->getChart();
                ui->txtBrowserShowChart ->setText(s2q(chart_count));

                string record = r->getWorkingCod();
                ui->txtBrowserRecordChart->setText(s2q(record));

                ui->edtOpenFileInput->setText("");
            }
        }
    }
}


void ChartTool::on_btnAppend_clicked()
{
    if (r->getWorkingCod() == ""){
        ui->txtWantAppend->setText("Haven't select target!");
    }
    else{
        string app = q2s(ui->txtWantAppend->toPlainText());
        ui->txtWantAppend->setText("");

        r->appendToWorking(app);

        r->refreshWorking();

        string chart_count = r->getChart();
        ui->txtBrowserShowChart->setText(s2q(chart_count));

        string record = r->getWorkingCod();
        ui->txtBrowserRecordChart->setText(s2q(record));

        ui->txtWantAppend->setText("");
    }
}
