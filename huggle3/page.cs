﻿//This is a source code or part of Huggle project
//
//This file contains code for
//last modified by Petrb

//Copyright (C) 2011 Huggle team
//This program is free software: you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License, or
//(at your option) any later version.

//This program is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU General Public License for more details.

using System;
using System.Collections.Generic;
using System.Text;

namespace huggle3
{
    public class page
    {
        /// <summary>
        /// Name of the article
        /// </summary>
        public string Name;
        public space _Space = new space();
        /// <summary>
        /// Does the page exist
        /// </summary>
        public bool Exists;
        private Dictionary<string, page> Shared_All;
        /// <summary>
        /// First Edit
        /// </summary>
        public edit FirstEdit;
        /// <summary>
        /// Current edit
        /// </summary>
        public edit LastEdit;
        public PageLevel level;
        public static List<string> deletes;
        public bool DeletesCurrent;
        //public List<Protection> protection;
        public bool ProtectionsCurrent;
        public string HistoryOffset;
        /// <summary>
        /// Has the page been patrolled
        /// </summary>
        public bool patrolled;
        public string Rcid;
        public SpeedyCriterion SpeedyCrit;
        /// <summary>
        /// Page text content
        /// </summary>
        public string Text;
        public string EditLevel;
        public bool Pending;
        public string MoveLevel;

        public page(string Name )
        {
            this.Name = Name;
            _Space = space.Article;
            Shared_All.Add(Name, this);
        }

        public page()
        {
            // special contructor, obsolete
            this.Name = "Special:Unknown";
            Shared_All.Add(Name, this);
        }

        public enum PageLevel
        {
            None = 0,
            Ignore = -1,
            Watch = 1,
            Bad = 2        
        }

        public enum ProtectionType
        { 
            None,
            Confirmed,
            Sysop,
            PC
        }

        public class SpeedyCriterion
        {
            public string Code;
            public string DisplayCode;
            public string Description;
            public string Template;
            public string Parameter;
        }
    }

    
}
