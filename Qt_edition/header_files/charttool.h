#ifndef CHARTTOOL_H
#define CHARTTOOL_H

#include <QMainWindow>
#include "ReadFile.h"

QT_BEGIN_NAMESPACE
namespace Ui { class ChartTool; }
QT_END_NAMESPACE

class ChartTool : public QMainWindow
{
    Q_OBJECT

public:
    ChartTool(QWidget *parent = nullptr);

    QString s2q( const string &);
    string q2s( const QString &);

    ~ChartTool();

private slots:
    void on_btnValidPush_clicked();

    void on_btnAppend_clicked();

private:
    Ui::ChartTool *ui;
    ReadFile *r;
};
#endif // CHARTTOOL_H
