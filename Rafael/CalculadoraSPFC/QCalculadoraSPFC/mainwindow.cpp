#include "mainwindow.h"
#include "ui_mainwindow.h"
#include <QtGui>
#include <QtCore>
#include <QtWidgets>
#include <QList>
#include <QDebug>

//---- GLOBALS ------

QList<double> Values;
bool ResultShown = false;
//- - - - - - - - - -

MainWindow::MainWindow(QWidget *parent) : QMainWindow(parent), ui(new Ui::MainWindow)
{
    ui->setupUi(this);
}

MainWindow::~MainWindow()
{
    delete ui;
}


void MainWindow::on_Num0_clicked()
{
    if(ResultShown)
        ui->lineEdit->clear();

    if(ui->lineEdit->text().isEmpty())
        ui->lineEdit->setText("0");
    else
        ui->lineEdit->setText(ui->lineEdit->text() + "0");
}
void MainWindow::on_Num1_clicked()
{
    if(ResultShown)
        ui->lineEdit->clear();

    if(ui->lineEdit->text().isEmpty())
        ui->lineEdit->setText("1");
    else
        ui->lineEdit->setText(ui->lineEdit->text() + "1");
}
void MainWindow::on_Num2_clicked()
{
    if(ResultShown)
        ui->lineEdit->clear();

    if(ui->lineEdit->text().isEmpty())
        ui->lineEdit->setText("2");
    else
        ui->lineEdit->setText(ui->lineEdit->text() + "2");
}
void MainWindow::on_Num3_clicked()
{
    if(ResultShown)
        ui->lineEdit->clear();

    if(ui->lineEdit->text().isEmpty())
        ui->lineEdit->setText("3");
    else
        ui->lineEdit->setText(ui->lineEdit->text() + "3");
}
void MainWindow::on_Num4_clicked()
{
    if(ResultShown)
        ui->lineEdit->clear();

    if(ui->lineEdit->text().isEmpty())
        ui->lineEdit->setText("4");
    else
        ui->lineEdit->setText(ui->lineEdit->text() + "4");
}
void MainWindow::on_Num5_clicked()
{
    if(ResultShown)
        ui->lineEdit->clear();

    if(ui->lineEdit->text().isEmpty())
        ui->lineEdit->setText("5");
    else
        ui->lineEdit->setText(ui->lineEdit->text() + "5");
}
void MainWindow::on_Num6_clicked()
{
    if(ResultShown)
        ui->lineEdit->clear();

    if(ui->lineEdit->text().isEmpty())
        ui->lineEdit->setText("6");
    else
        ui->lineEdit->setText(ui->lineEdit->text() + "6");
}
void MainWindow::on_Num7_clicked()
{
    if(ResultShown)
        ui->lineEdit->clear();

    if(ui->lineEdit->text().isEmpty())
        ui->lineEdit->setText("7");
    else
        ui->lineEdit->setText(ui->lineEdit->text() + "7");
}
void MainWindow::on_Num8_clicked()
{
    if(ResultShown)
        ui->lineEdit->clear();

    if(ui->lineEdit->text().isEmpty())
        ui->lineEdit->setText("8");
    else
        ui->lineEdit->setText(ui->lineEdit->text() + "8");
}
void MainWindow::on_Num9_clicked()
{
    if(ResultShown)
        ui->lineEdit->clear();

    if(ui->lineEdit->text().isEmpty())
        ui->lineEdit->setText("9");
    else
        ui->lineEdit->setText(ui->lineEdit->text() + "9");
}

void MainWindow::on_OPplus_clicked()
{
    if(ui->lineEdit->text().isEmpty())
        if(Values.isEmpty())
        {
            Values.append(0);
            ui->lineEdit->clear();
        }

    if(!ui->lineEdit->text().isEmpty()){
        if(Values.isEmpty())
        {
            Values.append(ui->lineEdit->text().toDouble());
            ui->lineEdit->clear();
        }
    }

    if(!ui->lineEdit->text().isEmpty()){
        if(!Values.isEmpty())
        {
           double x;
           x = Values.first();
           Values.clear();
           x += ui->lineEdit->text().toDouble();
           Values.append(x);
           ui->lineEdit->clear();
           QString s = QString::number(x);
           //QMessageBox::information(this, "c", s);
           ui->lineEdit->setText(s);
           ResultShown = true;
        }
    }

    else
        Values.append(ui->lineEdit->text().toDouble());
}


void MainWindow::on_ClearButton_clicked()
{
    ui->lineEdit->clear();
    Values.clear();
    ResultShown = false;
}

void MainWindow::on_EqualsButton_clicked()
{
    double x;
    x = Values.first();
    Values.clear();
    x += ui->lineEdit->text().toDouble();
    Values.append(x);
    ui->lineEdit->clear();
    QString s = QString::number(x);
    //QMessageBox::information(this, "c", s);
    ui->lineEdit->setText(s);
    Values.clear();
    ResultShown = true;
}

void MainWindow::on_CButton_clicked()
{
    ui->lineEdit->clear();
}
