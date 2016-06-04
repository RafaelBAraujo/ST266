/********************************************************************************
** Form generated from reading UI file 'mainwindow.ui'
**
** Created by: Qt User Interface Compiler version 5.6.0
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_MAINWINDOW_H
#define UI_MAINWINDOW_H

#include <QtCore/QVariant>
#include <QtWidgets/QAction>
#include <QtWidgets/QApplication>
#include <QtWidgets/QButtonGroup>
#include <QtWidgets/QHeaderView>
#include <QtWidgets/QLineEdit>
#include <QtWidgets/QMainWindow>
#include <QtWidgets/QMenuBar>
#include <QtWidgets/QPushButton>
#include <QtWidgets/QToolBar>
#include <QtWidgets/QWidget>

QT_BEGIN_NAMESPACE

class Ui_MainWindow
{
public:
    QWidget *centralWidget;
    QLineEdit *lineEdit;
    QPushButton *OPplus;
    QPushButton *ClearButton;
    QPushButton *EqualsButton;
    QPushButton *Num0;
    QPushButton *CButton;
    QPushButton *OPtimes;
    QPushButton *OPminus;
    QPushButton *OPdiv;
    QPushButton *Emblem;
    QPushButton *OPsqrt;
    QPushButton *OPexp;
    QPushButton *Comma;
    QPushButton *Num7;
    QPushButton *Num9;
    QPushButton *Num8;
    QPushButton *Num4;
    QPushButton *Num5;
    QPushButton *Num6;
    QPushButton *Num3;
    QPushButton *Num2;
    QPushButton *Num1;
    QMenuBar *menuBar;
    QToolBar *mainToolBar;

    void setupUi(QMainWindow *MainWindow)
    {
        if (MainWindow->objectName().isEmpty())
            MainWindow->setObjectName(QStringLiteral("MainWindow"));
        MainWindow->setEnabled(true);
        MainWindow->resize(374, 240);
        QSizePolicy sizePolicy(QSizePolicy::Preferred, QSizePolicy::Preferred);
        sizePolicy.setHorizontalStretch(0);
        sizePolicy.setVerticalStretch(0);
        sizePolicy.setHeightForWidth(MainWindow->sizePolicy().hasHeightForWidth());
        MainWindow->setSizePolicy(sizePolicy);
        MainWindow->setMinimumSize(QSize(123, 123));
        MainWindow->setMaximumSize(QSize(2323, 32323));
        centralWidget = new QWidget(MainWindow);
        centralWidget->setObjectName(QStringLiteral("centralWidget"));
        lineEdit = new QLineEdit(centralWidget);
        lineEdit->setObjectName(QStringLiteral("lineEdit"));
        lineEdit->setGeometry(QRect(7, 10, 361, 51));
        QPalette palette;
        QBrush brush(QColor(255, 255, 255, 255));
        brush.setStyle(Qt::SolidPattern);
        palette.setBrush(QPalette::Active, QPalette::Text, brush);
        QBrush brush1(QColor(0, 0, 0, 255));
        brush1.setStyle(Qt::SolidPattern);
        palette.setBrush(QPalette::Active, QPalette::Base, brush1);
        palette.setBrush(QPalette::Inactive, QPalette::Text, brush);
        palette.setBrush(QPalette::Inactive, QPalette::Base, brush1);
        QBrush brush2(QColor(120, 120, 120, 255));
        brush2.setStyle(Qt::SolidPattern);
        palette.setBrush(QPalette::Disabled, QPalette::Text, brush2);
        QBrush brush3(QColor(240, 240, 240, 255));
        brush3.setStyle(Qt::SolidPattern);
        palette.setBrush(QPalette::Disabled, QPalette::Base, brush3);
        lineEdit->setPalette(palette);
        QFont font;
        font.setPointSize(20);
        lineEdit->setFont(font);
        lineEdit->setAlignment(Qt::AlignRight|Qt::AlignTrailing|Qt::AlignVCenter);
        lineEdit->setReadOnly(true);
        OPplus = new QPushButton(centralWidget);
        OPplus->setObjectName(QStringLiteral("OPplus"));
        OPplus->setGeometry(QRect(225, 161, 50, 29));
        ClearButton = new QPushButton(centralWidget);
        ClearButton->setObjectName(QStringLiteral("ClearButton"));
        ClearButton->setGeometry(QRect(321, 71, 38, 43));
        QPalette palette1;
        palette1.setBrush(QPalette::Active, QPalette::ButtonText, brush);
        palette1.setBrush(QPalette::Inactive, QPalette::ButtonText, brush);
        palette1.setBrush(QPalette::Disabled, QPalette::ButtonText, brush2);
        ClearButton->setPalette(palette1);
        EqualsButton = new QPushButton(centralWidget);
        EqualsButton->setObjectName(QStringLiteral("EqualsButton"));
        EqualsButton->setGeometry(QRect(82, 193, 193, 21));
        QPalette palette2;
        palette2.setBrush(QPalette::Active, QPalette::ButtonText, brush);
        palette2.setBrush(QPalette::Inactive, QPalette::ButtonText, brush);
        palette2.setBrush(QPalette::Disabled, QPalette::ButtonText, brush2);
        EqualsButton->setPalette(palette2);
        QFont font1;
        font1.setPointSize(12);
        EqualsButton->setFont(font1);
        Num0 = new QPushButton(centralWidget);
        Num0->setObjectName(QStringLiteral("Num0"));
        Num0->setGeometry(QRect(82, 161, 65, 29));
        QPalette palette3;
        palette3.setBrush(QPalette::Active, QPalette::ButtonText, brush);
        palette3.setBrush(QPalette::Inactive, QPalette::ButtonText, brush);
        palette3.setBrush(QPalette::Disabled, QPalette::ButtonText, brush2);
        Num0->setPalette(palette3);
        CButton = new QPushButton(centralWidget);
        CButton->setObjectName(QStringLiteral("CButton"));
        CButton->setGeometry(QRect(282, 71, 38, 43));
        QPalette palette4;
        palette4.setBrush(QPalette::Active, QPalette::ButtonText, brush);
        palette4.setBrush(QPalette::Inactive, QPalette::ButtonText, brush);
        palette4.setBrush(QPalette::Disabled, QPalette::ButtonText, brush2);
        CButton->setPalette(palette4);
        OPtimes = new QPushButton(centralWidget);
        OPtimes->setObjectName(QStringLiteral("OPtimes"));
        OPtimes->setGeometry(QRect(225, 71, 50, 29));
        QFont font2;
        font2.setPointSize(10);
        OPtimes->setFont(font2);
        OPminus = new QPushButton(centralWidget);
        OPminus->setObjectName(QStringLiteral("OPminus"));
        OPminus->setGeometry(QRect(225, 131, 50, 29));
        OPminus->setFont(font1);
        OPdiv = new QPushButton(centralWidget);
        OPdiv->setObjectName(QStringLiteral("OPdiv"));
        OPdiv->setGeometry(QRect(225, 101, 50, 29));
        OPdiv->setFont(font2);
        Emblem = new QPushButton(centralWidget);
        Emblem->setObjectName(QStringLiteral("Emblem"));
        Emblem->setGeometry(QRect(10, 161, 65, 53));
        OPsqrt = new QPushButton(centralWidget);
        OPsqrt->setObjectName(QStringLiteral("OPsqrt"));
        OPsqrt->setGeometry(QRect(282, 121, 77, 43));
        QPalette palette5;
        palette5.setBrush(QPalette::Active, QPalette::ButtonText, brush);
        palette5.setBrush(QPalette::Inactive, QPalette::ButtonText, brush);
        palette5.setBrush(QPalette::Disabled, QPalette::ButtonText, brush2);
        OPsqrt->setPalette(palette5);
        OPexp = new QPushButton(centralWidget);
        OPexp->setObjectName(QStringLiteral("OPexp"));
        OPexp->setGeometry(QRect(282, 171, 77, 43));
        QPalette palette6;
        palette6.setBrush(QPalette::Active, QPalette::ButtonText, brush);
        palette6.setBrush(QPalette::Inactive, QPalette::ButtonText, brush);
        palette6.setBrush(QPalette::Disabled, QPalette::ButtonText, brush2);
        OPexp->setPalette(palette6);
        Comma = new QPushButton(centralWidget);
        Comma->setObjectName(QStringLiteral("Comma"));
        Comma->setGeometry(QRect(153, 161, 65, 29));
        QPalette palette7;
        palette7.setBrush(QPalette::Active, QPalette::ButtonText, brush);
        palette7.setBrush(QPalette::Inactive, QPalette::ButtonText, brush);
        palette7.setBrush(QPalette::Disabled, QPalette::ButtonText, brush2);
        Comma->setPalette(palette7);
        Num7 = new QPushButton(centralWidget);
        Num7->setObjectName(QStringLiteral("Num7"));
        Num7->setGeometry(QRect(10, 71, 66, 23));
        QPalette palette8;
        palette8.setBrush(QPalette::Active, QPalette::ButtonText, brush);
        palette8.setBrush(QPalette::Inactive, QPalette::ButtonText, brush);
        palette8.setBrush(QPalette::Disabled, QPalette::ButtonText, brush2);
        Num7->setPalette(palette8);
        Num9 = new QPushButton(centralWidget);
        Num9->setObjectName(QStringLiteral("Num9"));
        Num9->setGeometry(QRect(153, 71, 65, 23));
        QPalette palette9;
        palette9.setBrush(QPalette::Active, QPalette::ButtonText, brush);
        palette9.setBrush(QPalette::Inactive, QPalette::ButtonText, brush);
        palette9.setBrush(QPalette::Disabled, QPalette::ButtonText, brush2);
        Num9->setPalette(palette9);
        Num8 = new QPushButton(centralWidget);
        Num8->setObjectName(QStringLiteral("Num8"));
        Num8->setGeometry(QRect(82, 71, 65, 23));
        QPalette palette10;
        palette10.setBrush(QPalette::Active, QPalette::ButtonText, brush);
        palette10.setBrush(QPalette::Inactive, QPalette::ButtonText, brush);
        palette10.setBrush(QPalette::Disabled, QPalette::ButtonText, brush2);
        Num8->setPalette(palette10);
        Num4 = new QPushButton(centralWidget);
        Num4->setObjectName(QStringLiteral("Num4"));
        Num4->setGeometry(QRect(10, 101, 66, 23));
        QPalette palette11;
        palette11.setBrush(QPalette::Active, QPalette::ButtonText, brush);
        palette11.setBrush(QPalette::Inactive, QPalette::ButtonText, brush);
        palette11.setBrush(QPalette::Disabled, QPalette::ButtonText, brush2);
        Num4->setPalette(palette11);
        Num5 = new QPushButton(centralWidget);
        Num5->setObjectName(QStringLiteral("Num5"));
        Num5->setGeometry(QRect(82, 101, 65, 23));
        QPalette palette12;
        palette12.setBrush(QPalette::Active, QPalette::ButtonText, brush);
        palette12.setBrush(QPalette::Inactive, QPalette::ButtonText, brush);
        palette12.setBrush(QPalette::Disabled, QPalette::ButtonText, brush2);
        Num5->setPalette(palette12);
        Num6 = new QPushButton(centralWidget);
        Num6->setObjectName(QStringLiteral("Num6"));
        Num6->setGeometry(QRect(153, 101, 65, 23));
        QPalette palette13;
        palette13.setBrush(QPalette::Active, QPalette::ButtonText, brush);
        palette13.setBrush(QPalette::Inactive, QPalette::ButtonText, brush);
        palette13.setBrush(QPalette::Disabled, QPalette::ButtonText, brush2);
        Num6->setPalette(palette13);
        Num3 = new QPushButton(centralWidget);
        Num3->setObjectName(QStringLiteral("Num3"));
        Num3->setGeometry(QRect(153, 131, 65, 23));
        QPalette palette14;
        palette14.setBrush(QPalette::Active, QPalette::ButtonText, brush);
        palette14.setBrush(QPalette::Inactive, QPalette::ButtonText, brush);
        palette14.setBrush(QPalette::Disabled, QPalette::ButtonText, brush2);
        Num3->setPalette(palette14);
        Num2 = new QPushButton(centralWidget);
        Num2->setObjectName(QStringLiteral("Num2"));
        Num2->setGeometry(QRect(82, 131, 65, 23));
        QPalette palette15;
        palette15.setBrush(QPalette::Active, QPalette::ButtonText, brush);
        palette15.setBrush(QPalette::Inactive, QPalette::ButtonText, brush);
        palette15.setBrush(QPalette::Disabled, QPalette::ButtonText, brush2);
        Num2->setPalette(palette15);
        Num1 = new QPushButton(centralWidget);
        Num1->setObjectName(QStringLiteral("Num1"));
        Num1->setGeometry(QRect(10, 131, 66, 23));
        QPalette palette16;
        palette16.setBrush(QPalette::Active, QPalette::ButtonText, brush);
        palette16.setBrush(QPalette::Inactive, QPalette::ButtonText, brush);
        palette16.setBrush(QPalette::Disabled, QPalette::ButtonText, brush2);
        Num1->setPalette(palette16);
        MainWindow->setCentralWidget(centralWidget);
        menuBar = new QMenuBar(MainWindow);
        menuBar->setObjectName(QStringLiteral("menuBar"));
        menuBar->setGeometry(QRect(0, 0, 374, 21));
        MainWindow->setMenuBar(menuBar);
        mainToolBar = new QToolBar(MainWindow);
        mainToolBar->setObjectName(QStringLiteral("mainToolBar"));
        MainWindow->addToolBar(Qt::TopToolBarArea, mainToolBar);

        retranslateUi(MainWindow);

        QMetaObject::connectSlotsByName(MainWindow);
    } // setupUi

    void retranslateUi(QMainWindow *MainWindow)
    {
        MainWindow->setWindowTitle(QApplication::translate("MainWindow", "CalculadoraSPFC", 0));
        OPplus->setText(QApplication::translate("MainWindow", "+", 0));
        ClearButton->setText(QApplication::translate("MainWindow", "CE", 0));
        EqualsButton->setText(QApplication::translate("MainWindow", "=", 0));
        Num0->setText(QApplication::translate("MainWindow", "0", 0));
        CButton->setText(QApplication::translate("MainWindow", "C", 0));
        OPtimes->setText(QApplication::translate("MainWindow", "*", 0));
        OPminus->setText(QApplication::translate("MainWindow", "-", 0));
        OPdiv->setText(QApplication::translate("MainWindow", "/", 0));
        Emblem->setText(QString());
        OPsqrt->setText(QApplication::translate("MainWindow", "\342\210\232", 0));
        OPexp->setText(QApplication::translate("MainWindow", "x\302\262", 0));
        Comma->setText(QApplication::translate("MainWindow", ",", 0));
        Num7->setText(QApplication::translate("MainWindow", "7", 0));
        Num9->setText(QApplication::translate("MainWindow", "9", 0));
        Num8->setText(QApplication::translate("MainWindow", "8", 0));
        Num4->setText(QApplication::translate("MainWindow", "4", 0));
        Num5->setText(QApplication::translate("MainWindow", "5", 0));
        Num6->setText(QApplication::translate("MainWindow", "6", 0));
        Num3->setText(QApplication::translate("MainWindow", "3", 0));
        Num2->setText(QApplication::translate("MainWindow", "2", 0));
        Num1->setText(QApplication::translate("MainWindow", "1", 0));
    } // retranslateUi

};

namespace Ui {
    class MainWindow: public Ui_MainWindow {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_MAINWINDOW_H
