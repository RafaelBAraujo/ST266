/********************************************************************************
** Form generated from reading UI file 'about.ui'
**
** Created by: Qt User Interface Compiler version 5.6.0
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_ABOUT_H
#define UI_ABOUT_H

#include <QtCore/QVariant>
#include <QtWidgets/QAction>
#include <QtWidgets/QApplication>
#include <QtWidgets/QButtonGroup>
#include <QtWidgets/QDialog>
#include <QtWidgets/QHeaderView>
#include <QtWidgets/QLabel>
#include <QtWidgets/QPushButton>

QT_BEGIN_NAMESPACE

class Ui_About
{
public:
    QLabel *Emblem_label;
    QLabel *Text_label;
    QLabel *label;
    QLabel *label_2;
    QLabel *label_3;
    QLabel *label_4;
    QLabel *label_5;
    QLabel *label_6;
    QLabel *label_7;
    QPushButton *pushButton;

    void setupUi(QDialog *About)
    {
        if (About->objectName().isEmpty())
            About->setObjectName(QStringLiteral("About"));
        About->resize(363, 160);
        Emblem_label = new QLabel(About);
        Emblem_label->setObjectName(QStringLiteral("Emblem_label"));
        Emblem_label->setGeometry(QRect(12, 12, 100, 100));
        Emblem_label->setPixmap(QPixmap(QString::fromUtf8(":/MyImages/saopaulo.png")));
        Text_label = new QLabel(About);
        Text_label->setObjectName(QStringLiteral("Text_label"));
        Text_label->setGeometry(QRect(146, 15, 151, 16));
        QFont font;
        font.setPointSize(9);
        Text_label->setFont(font);
        Text_label->setTextFormat(Qt::PlainText);
        Text_label->setAlignment(Qt::AlignLeading|Qt::AlignLeft|Qt::AlignTop);
        label = new QLabel(About);
        label->setObjectName(QStringLiteral("label"));
        label->setGeometry(QRect(206, 32, 61, 16));
        label_2 = new QLabel(About);
        label_2->setObjectName(QStringLiteral("label_2"));
        label_2->setGeometry(QRect(10, 132, 161, 16));
        label_3 = new QLabel(About);
        label_3->setObjectName(QStringLiteral("label_3"));
        label_3->setGeometry(QRect(150, 57, 181, 16));
        label_4 = new QLabel(About);
        label_4->setObjectName(QStringLiteral("label_4"));
        label_4->setGeometry(QRect(153, 71, 181, 16));
        label_5 = new QLabel(About);
        label_5->setObjectName(QStringLiteral("label_5"));
        label_5->setGeometry(QRect(10, 120, 111, 16));
        QFont font1;
        font1.setPointSize(7);
        label_5->setFont(font1);
        label_6 = new QLabel(About);
        label_6->setObjectName(QStringLiteral("label_6"));
        label_6->setGeometry(QRect(143, 100, 191, 16));
        label_7 = new QLabel(About);
        label_7->setObjectName(QStringLiteral("label_7"));
        label_7->setGeometry(QRect(274, -2, 91, 16));
        label_7->setFont(font1);
        pushButton = new QPushButton(About);
        pushButton->setObjectName(QStringLiteral("pushButton"));
        pushButton->setGeometry(QRect(281, 130, 75, 23));

        retranslateUi(About);
        QObject::connect(pushButton, SIGNAL(clicked()), About, SLOT(close()));

        QMetaObject::connectSlotsByName(About);
    } // setupUi

    void retranslateUi(QDialog *About)
    {
        About->setWindowTitle(QApplication::translate("About", "About", 0));
        Emblem_label->setText(QString());
        Text_label->setText(QApplication::translate("About", "           CalculadoraSPFC", 0));
        label->setText(QApplication::translate("About", "Vers\303\243o 1.1", 0));
        label_2->setText(QApplication::translate("About", "Developed by: Rafael B. Ara\303\272jo", 0));
        label_3->setText(QApplication::translate("About", "For any further information access:", 0));
        label_4->setText(QApplication::translate("About", "github.com/RafaelBAraujo/ST266", 0));
        label_5->setText(QApplication::translate("About", "Last updated: 06/09/2016", 0));
        label_6->setText(QApplication::translate("About", "Thanks for choosing CalculadoraSPFC!", 0));
        label_7->setText(QApplication::translate("About", "Barbaroto's Software", 0));
        pushButton->setText(QApplication::translate("About", "OK", 0));
    } // retranslateUi

};

namespace Ui {
    class About: public Ui_About {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_ABOUT_H
