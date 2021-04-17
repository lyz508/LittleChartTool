#include "charttool.h"

#include <QApplication>

int main(int argc, char *argv[])
{
    QApplication a(argc, argv);
    ChartTool w;
    w.show();
    return a.exec();
}
