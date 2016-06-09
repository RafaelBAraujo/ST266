#ifndef MAINWINDOW_H
#define MAINWINDOW_H

#include <QMainWindow>
#include <QtGui>
#include <QtCore>
#include <QtWidgets>

namespace Ui {
class MainWindow;
}

class MainWindow : public QMainWindow
{
    Q_OBJECT

public:
    explicit MainWindow(QWidget *parent = 0);
    ~MainWindow();

public slots:


private slots:
    void on_Num0_clicked();
    void on_Num1_clicked();
    void on_Num2_clicked();
    void on_Num3_clicked();
    void on_Num4_clicked();
    void on_Num5_clicked();
    void on_Num6_clicked();
    void on_Num7_clicked();
    void on_Num8_clicked();
    void on_Num9_clicked();

    void on_OPplus_clicked();
    void on_OPminus_clicked();
    void on_OPtimes_clicked();
    void on_OPdiv_clicked();

    void on_OPexp_clicked();
    void on_OPsqrt_clicked();

    void on_ClearButton_clicked();

    void on_EqualsButton_clicked();

    void on_CButton_clicked();

    void on_SignButton_clicked();

    void on_Comma_clicked();

    void on_Emblem_clicked();

private:
    Ui::MainWindow *ui;
};

#endif // MAINWINDOW_H
