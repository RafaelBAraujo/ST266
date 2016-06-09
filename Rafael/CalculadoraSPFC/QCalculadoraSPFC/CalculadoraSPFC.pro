#-------------------------------------------------
#
# Project created by QtCreator 2016-06-03T21:19:00
#
#-------------------------------------------------

QT       += core gui

greaterThan(QT_MAJOR_VERSION, 4): QT += widgets

TARGET = CalculadoraSPFC
TEMPLATE = app


SOURCES += main.cpp\
        mainwindow.cpp \
    about.cpp

HEADERS  += mainwindow.h \
    about.h

FORMS    += mainwindow.ui \
    about.ui

RC_FILE += CalculadoraSPFCRC.rc

RESOURCES += \
    myresources.qrc
