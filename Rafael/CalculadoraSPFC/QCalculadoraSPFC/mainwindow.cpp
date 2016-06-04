#include "mainwindow.h"
#include "ui_mainwindow.h"
#include <QtGui>
#include <QtCore>
#include <QtWidgets>
#include <QList>
#include <QDebug>
#include <QIcon>
#include <qmath.h>

//#include "about.h"

enum operand{ sum, min, mult, divs, square, expo };

//---- GLOBALS ------

QList<double> Values;
static bool ResultShown = false;
operand lastOPused = sum;
//- - - - - - - - - -

MainWindow::MainWindow(QWidget *parent) : QMainWindow(parent), ui(new Ui::MainWindow)
{


    ui->setupUi(this);
    ui->Num0->setStyleSheet("background-color:red");
    ui->Num1->setStyleSheet("background-color:red");
    ui->Num2->setStyleSheet("background-color:red");
    ui->Num3->setStyleSheet("background-color:red");
    ui->Num4->setStyleSheet("background-color:red");
    ui->Num5->setStyleSheet("background-color:red");
    ui->Num6->setStyleSheet("background-color:red");
    ui->Num7->setStyleSheet("background-color:red");
    ui->Num8->setStyleSheet("background-color:red");
    ui->Num9->setStyleSheet("background-color:red");
    ui->EqualsButton->setStyleSheet("background-color:red");
    ui->Comma->setStyleSheet("background-color:red");

    ui->OPplus->setStyleSheet("background-color:white");
    ui->OPminus->setStyleSheet("background-color:white");
    ui->OPtimes->setStyleSheet("background-color:white");
    ui->OPdiv->setStyleSheet("background-color:white");
    ui->OPsqrt->setStyleSheet("background-color:black");
    ui->OPexp->setStyleSheet("background-color:black");

    ui->ClearButton->setStyleSheet("background-color:black");
    ui->CButton->setStyleSheet("background-color:black");
    //ui->OFFButton->setStyleSheet("background-color:black");

    ui->Emblem->setIcon(QIcon("C:/Users/Rafael/Desktop/NEW PROJECT/CalculadoraSPFC/sp.ico"));
    ui->Emblem->setIconSize(QSize(70, 50));
    ui->Emblem->setStyleSheet("background-color:red");

    Values.clear();
    ui->lineEdit->clear();
}

MainWindow::~MainWindow()
{
    delete ui;
}

void MainWindow::on_Num0_clicked()
{
    if(ResultShown && !Values.isEmpty()){
        ui->lineEdit->clear();
    }

    if(ui->lineEdit->text().isEmpty()){
        ui->lineEdit->setText("0");
        ResultShown = false;
    }
    else
        ui->lineEdit->setText(ui->lineEdit->text() + "0");
}
void MainWindow::on_Num1_clicked()
{
    if(ResultShown && !Values.isEmpty()){
        ui->lineEdit->clear();
    }

    if(ui->lineEdit->text().isEmpty()){
        ui->lineEdit->setText("1");
        ResultShown = false;
    }
    else{
        ui->lineEdit->setText(ui->lineEdit->text() + "1");
    }
}
void MainWindow::on_Num2_clicked()
{
    if(ResultShown && !Values.isEmpty()){
        ui->lineEdit->clear();
    }

    if(ui->lineEdit->text().isEmpty()){
        ui->lineEdit->setText("2");
        ResultShown = false;
    }
    else
        ui->lineEdit->setText(ui->lineEdit->text() + "2");
}
void MainWindow::on_Num3_clicked()
{
    if(ResultShown && !Values.isEmpty()){
        ui->lineEdit->clear();
    }

    if(ui->lineEdit->text().isEmpty()){
        ui->lineEdit->setText("3");
        ResultShown = false;
    }
    else
        ui->lineEdit->setText(ui->lineEdit->text() + "3");
}
void MainWindow::on_Num4_clicked()
{
    if(ResultShown && !Values.isEmpty()){
        ui->lineEdit->clear();
    }

    if(ui->lineEdit->text().isEmpty()){
        ui->lineEdit->setText("4");
        ResultShown = false;
    }
    else
        ui->lineEdit->setText(ui->lineEdit->text() + "4");
}
void MainWindow::on_Num5_clicked()
{
    if(ResultShown && !Values.isEmpty()){
        ui->lineEdit->clear();
    }

    if(ui->lineEdit->text().isEmpty()){
        ui->lineEdit->setText("5");
        ResultShown = false;
    }
    else
        ui->lineEdit->setText(ui->lineEdit->text() + "5");
}
void MainWindow::on_Num6_clicked()
{
    if(ResultShown && !Values.isEmpty()){
        ui->lineEdit->clear();
    }

    if(ui->lineEdit->text().isEmpty()){
        ui->lineEdit->setText("6");
        ResultShown = false;
    }
    else
        ui->lineEdit->setText(ui->lineEdit->text() + "6");
}
void MainWindow::on_Num7_clicked()
{
    if(ResultShown && !Values.isEmpty()){
        ui->lineEdit->clear();
    }

    if(ui->lineEdit->text().isEmpty()){
        ui->lineEdit->setText("7");
        ResultShown = false;
    }
    else
        ui->lineEdit->setText(ui->lineEdit->text() + "7");
}
void MainWindow::on_Num8_clicked()
{
    if(ResultShown && !Values.isEmpty()){
        ui->lineEdit->clear();
    }

    if(ui->lineEdit->text().isEmpty()){
        ui->lineEdit->setText("8");
        ResultShown = false;
    }
    else
        ui->lineEdit->setText(ui->lineEdit->text() + "8");
}
void MainWindow::on_Num9_clicked()
{
    if(ResultShown && !Values.isEmpty()){
        ui->lineEdit->clear();
    }

    if(ui->lineEdit->text().isEmpty()){
        ui->lineEdit->setText("9");
        ResultShown = false;
    }
    else
        ui->lineEdit->setText(ui->lineEdit->text() + "9");
}

void MainWindow::on_OPplus_clicked()
{
    lastOPused = sum;
    if(ui->lineEdit->text().isEmpty())
        if(Values.isEmpty())
        {
            Values.append(0);
            ui->lineEdit->clear();
        }

    if(!ui->lineEdit->text().isEmpty())
    {
        if(Values.isEmpty())
        {
            Values.append(ui->lineEdit->text().toDouble());
            ui->lineEdit->clear();
        }
        else if(!Values.isEmpty())
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

void MainWindow::on_OPtimes_clicked()
{

    lastOPused = mult;
    if(ui->lineEdit->text().isEmpty())
        if(Values.isEmpty())
        {
            Values.append(0);
            ui->lineEdit->clear();
        }

    if(!ui->lineEdit->text().isEmpty())
    {
        if(Values.isEmpty())
        {
            Values.append(ui->lineEdit->text().toDouble());
            ui->lineEdit->clear();
        }
        else if(!Values.isEmpty())
        {
            double x;
            x = Values.first();
            Values.clear();
            x *= ui->lineEdit->text().toDouble();
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

void MainWindow::on_OPminus_clicked() {

    lastOPused = min;
    if(ui->lineEdit->text().isEmpty())
        if(Values.isEmpty())
        {
            Values.append(0);
            ui->lineEdit->clear();
        }

    if(!ui->lineEdit->text().isEmpty())
    {
        if(Values.isEmpty())
        {
            Values.append(ui->lineEdit->text().toDouble());
            ui->lineEdit->clear();
        }
        else if(!Values.isEmpty())
        {
            double x;
            x = Values.first();
            Values.clear();
            x -= ui->lineEdit->text().toDouble();
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
void MainWindow::on_OPdiv_clicked() {

    lastOPused = divs;
    if(ui->lineEdit->text().isEmpty())
        if(Values.isEmpty())
        {
            Values.append(0);
            ui->lineEdit->clear();
        }

    if(!ui->lineEdit->text().isEmpty())
    {
        if(Values.isEmpty())
        {
            Values.append(ui->lineEdit->text().toDouble());
            ui->lineEdit->clear();
        }
        else if(!Values.isEmpty())
        {
            double x;
            x = Values.first();
            Values.clear();
            x /= ui->lineEdit->text().toDouble();
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


void MainWindow::on_OPexp_clicked(){

    lastOPused = expo;
    if(ui->lineEdit->text().isEmpty())
    {
        ui->lineEdit->setText("0");
        ResultShown = true;
    }

    else
    {
        double x = ui->lineEdit->text().toDouble();
        QString s = QString::number(qPow(x, 2));
        ui->lineEdit->setText(s);
        ResultShown = true;
    }
}

void MainWindow::on_OPsqrt_clicked(){

    lastOPused = square;
    if(ui->lineEdit->text().isEmpty())
    {
        ui->lineEdit->setText("0");
        ResultShown = true;
    }

    else
    {
        double x = ui->lineEdit->text().toDouble();
        QString s = QString::number(qSqrt(x));
        ui->lineEdit->setText(s);
        ResultShown = true;
    }
}

void MainWindow::on_ClearButton_clicked()
{
    ui->lineEdit->clear();
    Values.clear();
    //Values.append(0);
    ResultShown = false;
}

void MainWindow::on_EqualsButton_clicked()
{
    /*double x;
    x = Values.first();
    Values.clear();



        if(lastOPused == operand::sum)
        {
             x += ui->lineEdit->text().toDouble();
        }
        else if(lastOPused == operand::min)
        {
            x -= ui->lineEdit->text().toDouble();
        }
        else if(lastOPused == operand::divs)
        {
            x /= ui->lineEdit->text().toDouble();
        }
        else if(lastOPused == operand::mult)
        {
            x *= ui->lineEdit->text().toDouble();
        }
        else if(lastOPused == operand::expo)
        {
            x = qPow(ui->lineEdit->text().toDouble(), 2);
        }
        else if(lastOPused == operand::square)
        {
            x = qSqrt(ui->lineEdit->text().toDouble());
        }

    Values.append(x);
    ui->lineEdit->clear();
    QString s = QString::number(x);
    //QMessageBox::information(this, "c", s);
    ui->lineEdit->setText(s);
    Values.clear();
    ResultShown = true;*/

    int MainWindow::on_EqualsButton_clicked()
    {
        Decimal = false;
        double x = 0;

            if(ResultShown == true)
            {
                /*x = ui->lineEdit->text().toDouble();
                if(lastOPused == operand::sum)
                {
                    x += x;
                    QString s = QString::number(x);
                    ui->lineEdit->setText(s);
                }
                else if(lastOPused == operand::divs)
                {
                    x /= x;
                    QString s = QString::number(x);
                    ui->lineEdit->setText(s);
                }
                else if(lastOPused == operand::min)
                {
                    x -= x;
                    QString s = QString::number(x);
                    ui->lineEdit->setText(s);
                }
                else if(lastOPused == operand::mult)
                {
                    x *= x;
                    QString s = QString::number(x);
                    ui->lineEdit->setText(s);
                }
                break;*/

            }
           else if(lastOPused == operand::none){

                Values.clear();
                ResultShown;
                ui->lineEdit->setText("0");

            }
            else if(lastOPused == operand::sum)
            {
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
            else if(lastOPused == operand::min)
            {
                x = Values.first();
                Values.clear();
                x -= ui->lineEdit->text().toDouble();
                Values.append(x);
                ui->lineEdit->clear();
                QString s = QString::number(x);
                //QMessageBox::information(this, "c", s);
                ui->lineEdit->setText(s);
                Values.clear();
                ResultShown = true;
            }
            else if(lastOPused == operand::divs)
            {
                x = Values.first();
                Values.clear();
                x /= ui->lineEdit->text().toDouble();
                Values.append(x);
                ui->lineEdit->clear();
                QString s = QString::number(x);
                //QMessageBox::information(this, "c", s);
                ui->lineEdit->setText(s);
                Values.clear();
                ResultShown = true;
            }
            else if(lastOPused == operand::mult)
            {
                x = Values.first();
                Values.clear();
                x *= ui->lineEdit->text().toDouble();
                Values.append(x);
                ui->lineEdit->clear();
                QString s = QString::number(x);
                //QMessageBox::information(this, "c", s);
                ui->lineEdit->setText(s);
                Values.clear();
                ResultShown = true;
            }
            else if(lastOPused == operand::expo)
            {
                x = Values.first();
                Values.clear();
                x = qPow(ui->lineEdit->text().toDouble(), 2);
                Values.append(x);
                ui->lineEdit->clear();
                QString s = QString::number(x);
                //QMessageBox::information(this, "c", s);
                ui->lineEdit->setText(s);
                Values.clear();
                ResultShown = true;
            }
            else if(lastOPused == operand::square)
            {
                x = Values.first();
                Values.clear();
                x = qSqrt(ui->lineEdit->text().toDouble());
                Values.append(x);
                ui->lineEdit->clear();
                QString s = QString::number(x);
                //QMessageBox::information(this, "c", s);
                ui->lineEdit->setText(s);
                Values.clear();
                ResultShown = true;
            }

        return 0;
    }
}

void MainWindow::on_CButton_clicked()
{
    ui->lineEdit->clear();
}
