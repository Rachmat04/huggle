//This program is free software: you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License, or
//(at your option) any later version.

//This program is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU General Public License for more details.

// comment this if you want to disable python support
#define PYTHONENGINE

#ifndef CONFIGURATION_H
#define CONFIGURATION_H

#include <QList>
#include <QString>
#include "wikisite.h"

class Configuration
{
public:
    ///////////////////////////
    // System
    ///////////////////////////
    //! Verbosity for debugging to terminal etc, can be switched with parameter --verbosity
    static unsigned int Verbosity;
    //! currently selected project
    static WikiSite Project;
    //! List of projects
    static QList<WikiSite> ProjectList;
    //! When this is true most of functions will not work
    static bool Restricted;
    static QString GetURLProtocolPrefix();
    //! Where the welcome message is stored
    static QString WelcomeMP;
    static int Cache_InfoSize;
    static bool PythonEngine;

    ///////////////////////////
    // Login
    ///////////////////////////

    //! User name
    static QString UserName;
    //! If SSL is being used
    static bool UsingSSL;
    //! Consumer key
    static QString WmfOAuthConsumerKey;
    //! Password
    static QString Password;

    /////////////////////////////
    // IRC
    /////////////////////////////

    //! Whether IRC is being used
    static bool UsingIRC;
    static QString IRCServer;
    static QString IRCNick;
    static QString IRCIdent;
    static quint16 IRCPort;
    Configuration();
};

#endif // CONFIGURATION_H
