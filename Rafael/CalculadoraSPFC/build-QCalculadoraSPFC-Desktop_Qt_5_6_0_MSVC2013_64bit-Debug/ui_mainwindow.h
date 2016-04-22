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
#include <QtWidgets/QHBoxLayout>
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
    QPushButton *OFFButton;
    QPushButton *pushButton;
    QPushButton *pushButton_2;
    QPushButton *pushButton_3;
    QWidget *widget;
    QHBoxLayout *horizontalLayout;
    QPushButton *Num7;
    QPushButton *Num8;
    QPushButton *Num9;
    QWidget *widget1;
    QHBoxLayout *horizontalLayout_2;
    QPushButton *Num4;
    QPushButton *Num5;
    QPushButton *Num6;
    QWidget *widget2;
    QHBoxLayout *horizontalLayout_3;
    QPushButton *Num1;
    QPushButton *Num2;
    QPushButton *Num3;
    QMenuBar *menuBar;
    QToolBar *mainToolBar;

    void setupUi(QMainWindow *MainWindow)
    {
        if (MainWindow->objectName().isEmpty())
            MainWindow->setObjectName(QStringLiteral("MainWindow"));
        MainWindow->resize(312, 275);
        centralWidget = new QWidget(MainWindow);
        centralWidget->setObjectName(QStringLiteral("centralWidget"));
        lineEdit = new QLineEdit(centralWidget);
        lineEdit->setObjectName(QStringLiteral("lineEdit"));
        lineEdit->setGeometry(QRect(10, 10, 291, 51));
        QFont font;
        font.setPointSize(20);
        lineEdit->setFont(font);
        lineEdit->setAlignment(Qt::AlignRight|Qt::AlignTrailing|Qt::AlignVCenter);
        OPplus = new QPushButton(centralWidget);
        OPplus->setObjectName(QStringLiteral("OPplus"));
        OPplus->setGeometry(QRect(5, 189, 75, 54));
        ClearButton = new QPushButton(centralWidget);
        ClearButton->setObjectName(QStringLiteral("ClearButton"));
        ClearButton->setGeometry(QRect(168, 70, 75, 23));
        EqualsButton = new QPushButton(centralWidget);
        EqualsButton->setObjectName(QStringLiteral("EqualsButton"));
        EqualsButton->setGeometry(QRect(168, 189, 75, 54));
        QFont font1;
        font1.setPointSize(12);
        EqualsButton->setFont(font1);
        Num0 = new QPushButton(centralWidget);
        Num0->setObjectName(QStringLiteral("Num0"));
        Num0->setGeometry(QRect(88, 189, 75, 54));
        CButton = new QPushButton(centralWidget);
        CButton->setObjectName(QStringLiteral("CButton"));
        CButton->setGeometry(QRect(87, 70, 75, 23));
        OFFButton = new QPushButton(centralWidget);
        OFFButton->setObjectName(QStringLiteral("OFFButton"));
        OFFButton->setGeometry(QRect(6, 70, 75, 23));
        pushButton = new QPushButton(centralWidget);
        pushButton->setObjectName(QStringLiteral("pushButton"));
        pushButton->setGeometry(QRect(248, 70, 60, 54));
        QFont font2;
        font2.setPointSize(10);
        pushButton->setFont(font2);
        pushButton_2 = new QPushButton(centralWidget);
        pushButton_2->setObjectName(QStringLiteral("pushButton_2"));
        pushButton_2->setGeometry(QRect(248, 189, 60, 54));
        pushButton_2->setFont(font1);
        pushButton_3 = new QPushButton(centralWidget);
        pushButton_3->setObjectName(QStringLiteral("pushButton_3"));
        pushButton_3->setGeometry(QRect(248, 130, 60, 54));
        pushButton_3->setFont(font2);
        widget = new QWidget(centralWidget);
        widget->setObjectName(QStringLiteral("widget"));
        widget->setGeometry(QRect(5, 100, 239, 25));
        horizontalLayout = new QHBoxLayout(widget);
        horizontalLayout->setSpacing(6);
        horizontalLayout->setContentsMargins(11, 11, 11, 11);
        horizontalLayout->setObjectName(QStringLiteral("horizontalLayout"));
        horizontalLayout->setContentsMargins(0, 0, 0, 0);
        Num7 = new QPushButton(widget);
        Num7->setObjectName(QStringLiteral("Num7"));

        horizontalLayout->addWidget(Num7);

        Num8 = new QPushButton(widget);
        Num8->setObjectName(QStringLiteral("Num8"));

        horizontalLayout->addWidget(Num8);

        Num9 = new QPushButton(widget);
        Num9->setObjectName(QStringLiteral("Num9"));

        horizontalLayout->addWidget(Num9);

        widget1 = new QWidget(centralWidget);
        widget1->setObjectName(QStringLiteral("widget1"));
        widget1->setGeometry(QRect(5, 130, 239, 25));
        horizontalLayout_2 = new QHBoxLayout(widget1);
        horizontalLayout_2->setSpacing(6);
        horizontalLayout_2->setContentsMargins(11, 11, 11, 11);
        horizontalLayout_2->setObjectName(QStringLiteral("horizontalLayout_2"));
        horizontalLayout_2->setContentsMargins(0, 0, 0, 0);
        Num4 = new QPushButton(widget1);
        Num4->setObjectName(QStringLiteral("Num4"));

        horizontalLayout_2->addWidget(Num4);

        Num5 = new QPushButton(widget1);
        Num5->setObjectName(QStringLiteral("Num5"));

        horizontalLayout_2->addWidget(Num5);

        Num6 = new QPushButton(widget1);
        Num6->setObjectName(QStringLiteral("Num6"));

        horizontalLayout_2->addWidget(Num6);

        widget2 = new QWidget(centralWidget);
        widget2->setObjectName(QStringLiteral("widget2"));
        widget2->setGeometry(QRect(5, 160, 239, 25));
        horizontalLayout_3 = new QHBoxLayout(widget2);
        horizontalLayout_3->setSpacing(6);
        horizontalLayout_3->setContentsMargins(11, 11, 11, 11);
        horizontalLayout_3->setObjectName(QStringLiteral("horizontalLayout_3"));
        horizontalLayout_3->setContentsMargins(0, 0, 0, 0);
        Num1 = new QPushButton(widget2);
        Num1->setObjectName(QStringLiteral("Num1"));

        horizontalLayout_3->addWidget(Num1);

        Num2 = new QPushButton(widget2);
        Num2->setObjectName(QStringLiteral("Num2"));

        horizontalLayout_3->addWidget(Num2);

        Num3 = new QPushButton(widget2);
        Num3->setObjectName(QStringLiteral("Num3"));

        horizontalLayout_3->addWidget(Num3);

        MainWindow->setCentralWidget(centralWidget);
        menuBar = new QMenuBar(MainWindow);
        menuBar->setObjectName(QStringLiteral("menuBar"));
        menuBar->setGeometry(QRect(0, 0, 312, 21));
        MainWindow->setMenuBar(menuBar);
        mainToolBar = new QToolBar(MainWindow);
        mainToolBar->setObjectName(QStringLiteral("mainToolBar"));
        MainWindow->addToolBar(Qt::TopToolBarArea, mainToolBar);

        retranslateUi(MainWindow);
        QObject::connect(OFFButton, SIGNAL(clicked()), MainWindow, SLOT(close()));

        QMetaObject::connectSlotsByName(MainWindow);
    } // setupUi

    void retranslateUi(QMainWindow *MainWindow)
    {
        MainWindow->setWindowTitle(QApplication::translate("MainWindow", "MainWindow", 0));
        OPplus->setText(QApplication::translate("MainWindow", "+", 0));
        ClearButton->setText(QApplication::translate("MainWindow", "CE", 0));
        EqualsButton->setText(QApplication::translate("MainWindow", "=", 0));
        Num0->setText(QApplication::translate("MainWindow", "0", 0));
        CButton->setText(QApplication::translate("MainWindow", "C", 0));
        OFFButton->setText(QApplication::translate("MainWindow", "OFF", 0));
        pushButton->setText(QApplication::translate("MainWindow", "*", 0));
        pushButton_2->setText(QApplication::translate("MainWindow", "-", 0));
        pushButton_3->setText(QApplication::translate("MainWindow", "/", 0));
        Num7->setText(QApplication::translate("MainWindow", "7", 0));
        Num8->setText(QApplication::translate("MainWindow", "8", 0));
        Num9->setText(QApplication::translate("MainWindow", "9", 0));
        Num4->setText(QApplication::translate("MainWindow", "4", 0));
        Num5->setText(QApplication::translate("MainWindow", "5", 0));
        Num6->setText(QApplication::translate("MainWindow", "6", 0));
        Num1->setText(QApplication::translate("MainWindow", "1", 0));
        Num2->setText(QApplication::translate("MainWindow", "2", 0));
        Num3->setText(QApplication::translate("MainWindow", "3", 0));
    } // retranslateUi

};

namespace Ui {
    class MainWindow: public Ui_MainWindow {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_MAINWINDOW_H
