﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace PremierLeague3
{
    static class Static
    {
        public static Dictionary<string, int> _standings_2004_2005 = null;
        public static Dictionary<string, int> _standings_2005_2006 = null;
        public static Dictionary<string, int> _standings_2006_2007 = null;
        public static Dictionary<string, int> _standings_2007_2008 = null;
        public static Dictionary<string, int> _standings_2008_2009 = null;
        public static Dictionary<string, int> _standings_2009_2010 = null;
        public static Dictionary<string, int> _standings_2010_2011 = null;
        public static Dictionary<string, int> _standings_2011_2012 = null;
        public static Dictionary<string, int> _standings_2012_2013 = null;
        public static Dictionary<string, int> _standings_2013_2014 = null;
        public static Dictionary<string, int> _standings_2014_2015 = null;
        public static Dictionary<string, int> _standings_2015_2016 = null;
        public static Dictionary<string, int> _standings_2016_2017 = null;
        public static Dictionary<string, int> _standings_2017_2018 = null;
        public static Dictionary<string, int> _standings_2018_2019 = null;

        public static void MakeAllStandings()
        {
            if (null == _standings_2004_2005)
            {
                _standings_2004_2005 = new Dictionary<string, int>();
                _standings_2004_2005.Add("Chelsea", 0);
                _standings_2004_2005.Add("Arsenal", 1);
                _standings_2004_2005.Add("Manchester Utd", 2);
                _standings_2004_2005.Add("Everton", 3);
                _standings_2004_2005.Add("Liverpool", 4);
                _standings_2004_2005.Add("Bolton", 5);
                _standings_2004_2005.Add("Middlesbrough", 6);
                _standings_2004_2005.Add("Manchester City", 7);
                _standings_2004_2005.Add("Tottenham", 8);
                _standings_2004_2005.Add("Aston Villa", 9);
                _standings_2004_2005.Add("Charlton", 10);
                _standings_2004_2005.Add("Birmingham", 11);
                _standings_2004_2005.Add("Fulham", 12);
                _standings_2004_2005.Add("Newcastle", 13);
                _standings_2004_2005.Add("Blackburn", 14);
                _standings_2004_2005.Add("Portsmouth", 15);
                _standings_2004_2005.Add("West Brom", 16);
                _standings_2004_2005.Add("Crystal Palace", 17);
                _standings_2004_2005.Add("Norwich", 18);
                _standings_2004_2005.Add("Southampton", 19);
            }

            if (null == _standings_2005_2006)
            {
                _standings_2005_2006 = new Dictionary<string, int>();
                _standings_2005_2006.Add("Chelsea", 0);
                _standings_2005_2006.Add("Manchester Utd", 1);
                _standings_2005_2006.Add("Liverpool", 2);
                _standings_2005_2006.Add("Arsenal", 3);
                _standings_2005_2006.Add("Tottenham", 4);
                _standings_2005_2006.Add("Blackburn", 5);
                _standings_2005_2006.Add("Newcastle", 6);
                _standings_2005_2006.Add("Bolton", 7);
                _standings_2005_2006.Add("West Ham", 8);
                _standings_2005_2006.Add("Wigan", 9);
                _standings_2005_2006.Add("Everton", 10);
                _standings_2005_2006.Add("Fulham", 11);
                _standings_2005_2006.Add("Charlton", 12);
                _standings_2005_2006.Add("Middlesbrough", 13);
                _standings_2005_2006.Add("Manchester City", 14);
                _standings_2005_2006.Add("Aston Villa", 15);
                _standings_2005_2006.Add("Portsmouth", 16);
                _standings_2005_2006.Add("Birmingham", 17);
                _standings_2005_2006.Add("West Brom", 18);
                _standings_2005_2006.Add("Sunderland", 19);
            }

            if (null == _standings_2006_2007)
            {
                _standings_2006_2007 = new Dictionary<string, int>();
                _standings_2006_2007.Add("Manchester Utd", 0);
                _standings_2006_2007.Add("Chelsea", 1);
                _standings_2006_2007.Add("Liverpool", 2);
                _standings_2006_2007.Add("Arsenal", 3);
                _standings_2006_2007.Add("Tottenham", 4);
                _standings_2006_2007.Add("Everton", 5);
                _standings_2006_2007.Add("Bolton", 6);
                _standings_2006_2007.Add("Reading", 7);
                _standings_2006_2007.Add("Portsmouth", 8);
                _standings_2006_2007.Add("Blackburn", 9);
                _standings_2006_2007.Add("Aston Villa", 10);
                _standings_2006_2007.Add("Middlesbrough", 11);
                _standings_2006_2007.Add("Newcastle", 12);
                _standings_2006_2007.Add("Manchester City", 13);
                _standings_2006_2007.Add("West Ham", 14);
                _standings_2006_2007.Add("Fulham", 15);
                _standings_2006_2007.Add("Wigan", 16);
                _standings_2006_2007.Add("Sheffield Utd", 17);
                _standings_2006_2007.Add("Charlton", 18);
                _standings_2006_2007.Add("Watford", 19);
            }

            if (null == _standings_2007_2008)
            {
                _standings_2007_2008 = new Dictionary<string, int>();
                _standings_2007_2008.Add("Manchester Utd", 0);
                _standings_2007_2008.Add("Chelsea", 1);
                _standings_2007_2008.Add("Arsenal", 2);
                _standings_2007_2008.Add("Liverpool", 3);
                _standings_2007_2008.Add("Everton", 4);
                _standings_2007_2008.Add("Aston Villa", 5);
                _standings_2007_2008.Add("Blackburn", 6);
                _standings_2007_2008.Add("Portsmouth", 7);
                _standings_2007_2008.Add("Manchester City", 8);
                _standings_2007_2008.Add("West Ham", 9);
                _standings_2007_2008.Add("Tottenham", 10);
                _standings_2007_2008.Add("Newcastle", 11);
                _standings_2007_2008.Add("Middlesbrough", 12);
                _standings_2007_2008.Add("Wigan", 13);
                _standings_2007_2008.Add("Sunderland", 14);
                _standings_2007_2008.Add("Bolton", 15);
                _standings_2007_2008.Add("Fulham", 16);
                _standings_2007_2008.Add("Reading", 17);
                _standings_2007_2008.Add("Birmingham", 18);
                _standings_2007_2008.Add("Derby", 19);
            }

            if (null == _standings_2008_2009)
            {
                _standings_2008_2009 = new Dictionary<string, int>();
                _standings_2008_2009.Add("Manchester Utd", 0);
                _standings_2008_2009.Add("Liverpool", 1);
                _standings_2008_2009.Add("Chelsea", 2);
                _standings_2008_2009.Add("Arsenal", 3);
                _standings_2008_2009.Add("Everton", 4);
                _standings_2008_2009.Add("Aston Villa", 5);
                _standings_2008_2009.Add("Fulham", 6);
                _standings_2008_2009.Add("Tottenham", 7);
                _standings_2008_2009.Add("West Ham", 8);
                _standings_2008_2009.Add("Manchester City", 9);
                _standings_2008_2009.Add("Wigan", 10);
                _standings_2008_2009.Add("Stoke", 11);
                _standings_2008_2009.Add("Bolton", 12);
                _standings_2008_2009.Add("Portsmouth", 13);
                _standings_2008_2009.Add("Blackburn", 14);
                _standings_2008_2009.Add("Sunderland", 15);
                _standings_2008_2009.Add("Hull", 16);
                _standings_2008_2009.Add("Newcastle", 17);
                _standings_2008_2009.Add("Middlesbrough", 18);
                _standings_2008_2009.Add("West Brom", 19);
            }

            if (null == _standings_2009_2010)
            {
                _standings_2009_2010 = new Dictionary<string, int>();
                _standings_2009_2010.Add("Chelsea", 0);
                _standings_2009_2010.Add("Manchester Utd", 1);
                _standings_2009_2010.Add("Arsenal", 2);
                _standings_2009_2010.Add("Tottenham", 3);
                _standings_2009_2010.Add("Manchester City", 4);
                _standings_2009_2010.Add("Aston Villa", 5);
                _standings_2009_2010.Add("Liverpool", 6);
                _standings_2009_2010.Add("Everton", 7);
                _standings_2009_2010.Add("Birmingham", 8);
                _standings_2009_2010.Add("Blackburn", 9);
                _standings_2009_2010.Add("Stoke", 10);
                _standings_2009_2010.Add("Fulham", 11);
                _standings_2009_2010.Add("Sunderland", 12);
                _standings_2009_2010.Add("Bolton", 13);
                _standings_2009_2010.Add("Wolves", 14);
                _standings_2009_2010.Add("Wigan", 15);
                _standings_2009_2010.Add("West Ham", 16);
                _standings_2009_2010.Add("Burnley", 17);
                _standings_2009_2010.Add("Hull", 18);
                _standings_2009_2010.Add("Portsmouth", 19);
            }

            if (null == _standings_2010_2011)
            {
                _standings_2010_2011 = new Dictionary<string, int>();
                _standings_2010_2011.Add("Manchester Utd", 0);
                _standings_2010_2011.Add("Chelsea", 1);
                _standings_2010_2011.Add("Manchester City", 2);
                _standings_2010_2011.Add("Arsenal", 3);
                _standings_2010_2011.Add("Tottenham", 4);
                _standings_2010_2011.Add("Liverpool", 5);
                _standings_2010_2011.Add("Everton", 6);
                _standings_2010_2011.Add("Fulham", 7);
                _standings_2010_2011.Add("Aston Villa", 8);
                _standings_2010_2011.Add("Sunderland", 9);
                _standings_2010_2011.Add("West Brom", 10);
                _standings_2010_2011.Add("Newcastle", 11);
                _standings_2010_2011.Add("Stoke", 12);
                _standings_2010_2011.Add("Bolton", 13);
                _standings_2010_2011.Add("Blackburn", 14);
                _standings_2010_2011.Add("Wigan", 15);
                _standings_2010_2011.Add("Wolves", 16);
                _standings_2010_2011.Add("Birmingham", 17);
                _standings_2010_2011.Add("Blackpool", 18);
                _standings_2010_2011.Add("West Ham", 19);
            }

            if (null == _standings_2011_2012)
            {
                _standings_2011_2012 = new Dictionary<string, int>();
                _standings_2011_2012.Add("Manchester City", 0);
                _standings_2011_2012.Add("Manchester Utd", 1);
                _standings_2011_2012.Add("Arsenal", 2);
                _standings_2011_2012.Add("Tottenham", 3);
                _standings_2011_2012.Add("Newcastle", 4);
                _standings_2011_2012.Add("Chelsea", 5);
                _standings_2011_2012.Add("Everton", 6);
                _standings_2011_2012.Add("Liverpool", 7);
                _standings_2011_2012.Add("Fulham", 8);
                _standings_2011_2012.Add("West Brom", 9);
                _standings_2011_2012.Add("Swansea", 10);
                _standings_2011_2012.Add("Norwich", 11);
                _standings_2011_2012.Add("Sunderland", 12);
                _standings_2011_2012.Add("Stoke", 13);
                _standings_2011_2012.Add("Wigan", 14);
                _standings_2011_2012.Add("Aston Villa", 15);
                _standings_2011_2012.Add("QPR", 16);
                _standings_2011_2012.Add("Bolton", 17);
                _standings_2011_2012.Add("Blackburn", 18);
                _standings_2011_2012.Add("Wolves", 19);
            }

            if (null == _standings_2012_2013)
            {
                _standings_2012_2013 = new Dictionary<string, int>();
                _standings_2012_2013.Add("Manchester Utd", 0);
                _standings_2012_2013.Add("Manchester City", 1);
                _standings_2012_2013.Add("Chelsea", 2);
                _standings_2012_2013.Add("Arsenal", 3);
                _standings_2012_2013.Add("Tottenham", 4);
                _standings_2012_2013.Add("Everton", 5);
                _standings_2012_2013.Add("Liverpool", 6);
                _standings_2012_2013.Add("West Brom", 7);
                _standings_2012_2013.Add("Swansea", 8);
                _standings_2012_2013.Add("West Ham", 9);
                _standings_2012_2013.Add("Norwich", 10);
                _standings_2012_2013.Add("Fulham", 11);
                _standings_2012_2013.Add("Stoke", 12);
                _standings_2012_2013.Add("Southampton", 13);
                _standings_2012_2013.Add("Aston Villa", 14);
                _standings_2012_2013.Add("Newcastle", 15);
                _standings_2012_2013.Add("Sunderland", 16);
                _standings_2012_2013.Add("Wigan", 17);
                _standings_2012_2013.Add("Reading", 18);
                _standings_2012_2013.Add("QPR", 19);
            }

            if (null == _standings_2013_2014)
            {
                _standings_2013_2014 = new Dictionary<string, int>();
                _standings_2013_2014.Add("Manchester City", 0);
                _standings_2013_2014.Add("Liverpool", 1);
                _standings_2013_2014.Add("Chelsea", 2);
                _standings_2013_2014.Add("Arsenal", 3);
                _standings_2013_2014.Add("Everton", 4);
                _standings_2013_2014.Add("Tottenham", 5);
                _standings_2013_2014.Add("Manchester Utd", 6);
                _standings_2013_2014.Add("Southampton", 7);
                _standings_2013_2014.Add("Stoke", 8);
                _standings_2013_2014.Add("Newcastle", 9);
                _standings_2013_2014.Add("Crystal Palace", 10);
                _standings_2013_2014.Add("Swansea", 11);
                _standings_2013_2014.Add("West Ham", 12);
                _standings_2013_2014.Add("Sunderland", 13);
                _standings_2013_2014.Add("Aston Villa", 14);
                _standings_2013_2014.Add("Hull", 15);
                _standings_2013_2014.Add("West Brom", 16);
                _standings_2013_2014.Add("Norwich", 17);
                _standings_2013_2014.Add("Fulham", 18);
                _standings_2013_2014.Add("Cardiff", 19);
            }

            if (null == _standings_2014_2015)
            {
                _standings_2014_2015 = new Dictionary<string, int>();
                _standings_2014_2015.Add("Chelsea", 0);
                _standings_2014_2015.Add("Manchester City", 1);
                _standings_2014_2015.Add("Arsenal", 2);
                _standings_2014_2015.Add("Manchester Utd", 3);
                _standings_2014_2015.Add("Tottenham", 4);
                _standings_2014_2015.Add("Liverpool", 5);
                _standings_2014_2015.Add("Southampton", 6);
                _standings_2014_2015.Add("Swansea", 7);
                _standings_2014_2015.Add("Stoke", 8);
                _standings_2014_2015.Add("Crystal Palace", 9);
                _standings_2014_2015.Add("Everton", 10);
                _standings_2014_2015.Add("West Ham", 11);
                _standings_2014_2015.Add("West Brom", 12);
                _standings_2014_2015.Add("Leicester", 13);
                _standings_2014_2015.Add("Newcastle", 14);
                _standings_2014_2015.Add("Sunderland", 15);
                _standings_2014_2015.Add("Aston Villa", 16);
                _standings_2014_2015.Add("Hull", 17);
                _standings_2014_2015.Add("Burnley", 18);
                _standings_2014_2015.Add("QPR", 19);
            }

            if (null == _standings_2015_2016)
            {
                _standings_2015_2016 = new Dictionary<string, int>();
                _standings_2015_2016.Add("Leicester", 0);
                _standings_2015_2016.Add("Arsenal", 1);
                _standings_2015_2016.Add("Tottenham", 2);
                _standings_2015_2016.Add("Manchester City", 3);
                _standings_2015_2016.Add("Manchester Utd", 4);
                _standings_2015_2016.Add("Southampton", 5);
                _standings_2015_2016.Add("West Ham", 6);
                _standings_2015_2016.Add("Liverpool", 7);
                _standings_2015_2016.Add("Stoke", 8);
                _standings_2015_2016.Add("Chelsea", 9);
                _standings_2015_2016.Add("Everton", 10);
                _standings_2015_2016.Add("Swansea", 11);
                _standings_2015_2016.Add("Watford", 12);
                _standings_2015_2016.Add("West Brom", 13);
                _standings_2015_2016.Add("Crystal Palace", 14);
                _standings_2015_2016.Add("Bournemouth", 15);
                _standings_2015_2016.Add("Sunderland", 16);
                _standings_2015_2016.Add("Newcastle", 17);
                _standings_2015_2016.Add("Norwich", 18);
                _standings_2015_2016.Add("Aston Villa", 19);
            }

            if (null == _standings_2016_2017)
            {
                _standings_2016_2017 = new Dictionary<string, int>();
                _standings_2016_2017.Add("Chelsea", 0);
                _standings_2016_2017.Add("Tottenham", 1);
                _standings_2016_2017.Add("Manchester City", 2);
                _standings_2016_2017.Add("Liverpool", 3);
                _standings_2016_2017.Add("Arsenal", 4);
                _standings_2016_2017.Add("Manchester Utd", 5);
                _standings_2016_2017.Add("Everton", 6);
                _standings_2016_2017.Add("Southampton", 7);
                _standings_2016_2017.Add("Bournemouth", 8);
                _standings_2016_2017.Add("West Brom", 9);
                _standings_2016_2017.Add("West Ham", 10);
                _standings_2016_2017.Add("Leicester", 11);
                _standings_2016_2017.Add("Stoke", 12);
                _standings_2016_2017.Add("Crystal Palace", 13);
                _standings_2016_2017.Add("Swansea", 14);
                _standings_2016_2017.Add("Burnley", 15);
                _standings_2016_2017.Add("Watford", 16);
                _standings_2016_2017.Add("Hull", 17);
                _standings_2016_2017.Add("Middlesbrough", 18);
                _standings_2016_2017.Add("Sunderland", 19);
            }

            if (null == _standings_2017_2018)
            {
                _standings_2017_2018 = new Dictionary<string, int>();
                _standings_2017_2018.Add("Manchester City", 0);
                _standings_2017_2018.Add("Manchester Utd", 1);
                _standings_2017_2018.Add("Tottenham", 2);
                _standings_2017_2018.Add("Liverpool", 3);
                _standings_2017_2018.Add("Chelsea", 4);
                _standings_2017_2018.Add("Arsenal", 5);
                _standings_2017_2018.Add("Burnley", 6);
                _standings_2017_2018.Add("Everton", 7);
                _standings_2017_2018.Add("Leicester", 8);
                _standings_2017_2018.Add("Newcastle", 9);
                _standings_2017_2018.Add("Crystal Palace", 10);
                _standings_2017_2018.Add("Bournemouth", 11);
                _standings_2017_2018.Add("West Ham", 12);
                _standings_2017_2018.Add("Watford", 13);
                _standings_2017_2018.Add("Brighton", 14);
                _standings_2017_2018.Add("Huddersfield", 15);
                _standings_2017_2018.Add("Southampton", 16);
                _standings_2017_2018.Add("Swansea", 17);
                _standings_2017_2018.Add("Stoke", 18);
                _standings_2017_2018.Add("West Brom", 19);
            }

            if (null == _standings_2018_2019)
            {
                _standings_2018_2019 = new Dictionary<string, int>();
                _standings_2018_2019.Add("Manchester City", 0);
                _standings_2018_2019.Add("Liverpool", 1);
                _standings_2018_2019.Add("Chelsea", 2);
                _standings_2018_2019.Add("Tottenham", 3);
                _standings_2018_2019.Add("Arsenal", 4);
                _standings_2018_2019.Add("Manchester Utd", 5);
                _standings_2018_2019.Add("Wolves", 6);
                _standings_2018_2019.Add("Everton", 7);
                _standings_2018_2019.Add("Leicester", 8);
                _standings_2018_2019.Add("West Ham", 9);
                _standings_2018_2019.Add("Watford", 10);
                _standings_2018_2019.Add("Crystal Palace", 11);
                _standings_2018_2019.Add("Newcastle", 12);
                _standings_2018_2019.Add("Bournemouth", 13);
                _standings_2018_2019.Add("Burnley", 14);
                _standings_2018_2019.Add("Southampton", 15);
                _standings_2018_2019.Add("Brighton", 16);
                _standings_2018_2019.Add("Cardiff", 17);
                _standings_2018_2019.Add("Fulham", 18);
                _standings_2018_2019.Add("Huddersfield", 19);
            }
        }

        public static void MakeTrainingData()
        {
            MakeAllStandings();
            DataReader dr = new DataReader();

            string TrainingDataFileName = "../../../DATA/Training-Data.csv";
            using (StreamWriter sw = new StreamWriter(TrainingDataFileName))
            {
                List<Game> list = dr.ProcessFile("../../../DATA/2004-2005.txt");
                foreach (Game game in list)
                {
                    int indexHome = Static._standings_2004_2005[game.teamHome];
                    int indexAway = Static._standings_2004_2005[game.teamAway];
                    int goalsDiff = game.goalsHome - game.goalsAway;

                    String oneLine = String.Format("{0}, {1}, {2}", indexHome, indexAway, goalsDiff);
                    sw.WriteLine(oneLine);
                }

                list = dr.ProcessFile("../../../DATA/2005-2006.txt");
                foreach (Game game in list)
                {
                    int indexHome = Static._standings_2005_2006[game.teamHome];
                    int indexAway = Static._standings_2005_2006[game.teamAway];
                    int goalsDiff = game.goalsHome - game.goalsAway;

                    String oneLine = String.Format("{0}, {1}, {2}", indexHome, indexAway, goalsDiff);
                    sw.WriteLine(oneLine);
                }

                list = dr.ProcessFile("../../../DATA/2006-2007.txt");
                foreach (Game game in list)
                {
                    int indexHome = Static._standings_2006_2007[game.teamHome];
                    int indexAway = Static._standings_2006_2007[game.teamAway];
                    int goalsDiff = game.goalsHome - game.goalsAway;

                    String oneLine = String.Format("{0}, {1}, {2}", indexHome, indexAway, goalsDiff);
                    sw.WriteLine(oneLine);
                }

                list = dr.ProcessFile("../../../DATA/2007-2008.txt");
                foreach (Game game in list)
                {
                    int indexHome = Static._standings_2007_2008[game.teamHome];
                    int indexAway = Static._standings_2007_2008[game.teamAway];
                    int goalsDiff = game.goalsHome - game.goalsAway;

                    String oneLine = String.Format("{0}, {1}, {2}", indexHome, indexAway, goalsDiff);
                    sw.WriteLine(oneLine);
                }

                list = dr.ProcessFile("../../../DATA/2008-2009.txt");
                foreach (Game game in list)
                {
                    int indexHome = Static._standings_2008_2009[game.teamHome];
                    int indexAway = Static._standings_2008_2009[game.teamAway];
                    int goalsDiff = game.goalsHome - game.goalsAway;

                    String oneLine = String.Format("{0}, {1}, {2}", indexHome, indexAway, goalsDiff);
                    sw.WriteLine(oneLine);
                }

                list = dr.ProcessFile("../../../DATA/2009-2010.txt");
                foreach (Game game in list)
                {
                    int indexHome = Static._standings_2009_2010[game.teamHome];
                    int indexAway = Static._standings_2009_2010[game.teamAway];
                    int goalsDiff = game.goalsHome - game.goalsAway;

                    String oneLine = String.Format("{0}, {1}, {2}", indexHome, indexAway, goalsDiff);
                    sw.WriteLine(oneLine);
                }

                list = dr.ProcessFile("../../../DATA/2010-2011.txt");
                foreach (Game game in list)
                {
                    int indexHome = Static._standings_2010_2011[game.teamHome];
                    int indexAway = Static._standings_2010_2011[game.teamAway];
                    int goalsDiff = game.goalsHome - game.goalsAway;

                    String oneLine = String.Format("{0}, {1}, {2}", indexHome, indexAway, goalsDiff);
                    sw.WriteLine(oneLine);
                }

                list = dr.ProcessFile("../../../DATA/2011-2012.txt");
                foreach (Game game in list)
                {
                    int indexHome = Static._standings_2011_2012[game.teamHome];
                    int indexAway = Static._standings_2011_2012[game.teamAway];
                    int goalsDiff = game.goalsHome - game.goalsAway;

                    String oneLine = String.Format("{0}, {1}, {2}", indexHome, indexAway, goalsDiff);
                    sw.WriteLine(oneLine);
                }

                list = dr.ProcessFile("../../../DATA/2012-2013.txt");
                foreach (Game game in list)
                {
                    int indexHome = Static._standings_2012_2013[game.teamHome];
                    int indexAway = Static._standings_2012_2013[game.teamAway];
                    int goalsDiff = game.goalsHome - game.goalsAway;

                    String oneLine = String.Format("{0}, {1}, {2}", indexHome, indexAway, goalsDiff);
                    sw.WriteLine(oneLine);
                }

                list = dr.ProcessFile("../../../DATA/2013-2014.txt");
                foreach (Game game in list)
                {
                    int indexHome = Static._standings_2013_2014[game.teamHome];
                    int indexAway = Static._standings_2013_2014[game.teamAway];
                    int goalsDiff = game.goalsHome - game.goalsAway;

                    String oneLine = String.Format("{0}, {1}, {2}", indexHome, indexAway, goalsDiff);
                    sw.WriteLine(oneLine);
                }

                list = dr.ProcessFile("../../../DATA/2014-2015.txt");
                foreach (Game game in list)
                {
                    int indexHome = Static._standings_2014_2015[game.teamHome];
                    int indexAway = Static._standings_2014_2015[game.teamAway];
                    int goalsDiff = game.goalsHome - game.goalsAway;

                    String oneLine = String.Format("{0}, {1}, {2}", indexHome, indexAway, goalsDiff);
                    sw.WriteLine(oneLine);
                }

                list = dr.ProcessFile("../../../DATA/2015-2016.txt");
                foreach (Game game in list)
                {
                    int indexHome = Static._standings_2015_2016[game.teamHome];
                    int indexAway = Static._standings_2015_2016[game.teamAway];
                    int goalsDiff = game.goalsHome - game.goalsAway;

                    String oneLine = String.Format("{0}, {1}, {2}", indexHome, indexAway, goalsDiff);
                    sw.WriteLine(oneLine);
                }

                list = dr.ProcessFile("../../../DATA/2016-2017.txt");
                foreach (Game game in list)
                {
                    int indexHome = Static._standings_2016_2017[game.teamHome];
                    int indexAway = Static._standings_2016_2017[game.teamAway];
                    int goalsDiff = game.goalsHome - game.goalsAway;

                    String oneLine = String.Format("{0}, {1}, {2}", indexHome, indexAway, goalsDiff);
                    sw.WriteLine(oneLine);
                }

                list = dr.ProcessFile("../../../DATA/2017-2018.txt");
                foreach (Game game in list)
                {
                    int indexHome = Static._standings_2017_2018[game.teamHome];
                    int indexAway = Static._standings_2017_2018[game.teamAway];
                    int goalsDiff = game.goalsHome - game.goalsAway;

                    String oneLine = String.Format("{0}, {1}, {2}", indexHome, indexAway, goalsDiff);
                    sw.WriteLine(oneLine);
                }

                list = dr.ProcessFile("../../../DATA/2018-2019.txt");
                foreach (Game game in list)
                {
                    int indexHome = Static._standings_2018_2019[game.teamHome];
                    int indexAway = Static._standings_2018_2019[game.teamAway];
                    int goalsDiff = game.goalsHome - game.goalsAway;

                    String oneLine = String.Format("{0}, {1}, {2}", indexHome, indexAway, goalsDiff);
                    sw.WriteLine(oneLine);
                }

                sw.Flush();
                sw.Close();
            }
        }

        public static double PearsonCorrelation(double[] x, double[] y)
        {
            int length = x.Length;
            if (length > y.Length)
            {
                length = y.Length;
            }

            double xy = 0.0;
            double x2 = 0.0;
            double y2 = 0.0;
            for (int i = 0; i < length; ++i)
            {
                xy += x[i] * y[i];
                x2 += x[i] * x[i];
                y2 += y[i] * y[i];
            }
            xy /= (double)(length);
            x2 /= (double)(length);
            y2 /= (double)(length);
            double xav = 0.0;
            for (int i = 0; i < length; ++i)
            {
                xav += x[i];
            }
            xav /= length;
            double yav = 0.0;
            for (int i = 0; i < length; ++i)
            {
                yav += y[i];
            }
            yav /= length;
            double ro = xy - xav * yav;
            ro /= Math.Sqrt(x2 - xav * xav);
            ro /= Math.Sqrt(y2 - yav * yav);
            return ro;
        }
    }
}
