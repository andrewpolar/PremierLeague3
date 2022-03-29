using System;
using System.IO;
using System.Collections.Generic;
using DDR;

//This is demo for selective prediction of soccer match outcome for British Premier League.
//It uses Divisive Data Resorting explained in https://arxiv.org/abs/2104.01714
//The deterministic component in ensemble explained in https://www.youtube.com/watch?v=eS_k6L638k0
//and also in two articles https://www.sciencedirect.com/science/article/abs/pii/S0016003220301149
//and https://www.sciencedirect.com/science/article/abs/pii/S0952197620303742

//Authors of the concept Andrew Polar and Mike Poluektov
//this code is written by Andrew Polar.

namespace PremierLeague3
{
    class TeamPerformance: IComparable
    {
        public string name { get; set; }
        public int wins { get; set; }
        public int draws { get; set; }
        public int scored { get; set; }
        public int missed { get; set; }

        public TeamPerformance(string NAME,  int WINS, int DRAWS, int SCORED, int MISSED)
        {
            name = NAME;
            wins = WINS;
            draws = DRAWS;
            scored = SCORED;
            missed = MISSED;
        }

        public int CompareTo(object obj)
        {
            TeamPerformance team = (TeamPerformance)(obj);
            if (team.wins * 3 + team.draws > this.wins * 3 + this.draws)
            {
                return 1;
            }
            if (team.wins * 3 + team.draws < this.wins * 3 + this.draws)
            {
                return -1;
            }
            else
            {
                if (team.scored - team.missed > this.scored - this.missed)
                {
                    return 1;
                }
                if (team.scored - team.missed < this.scored - this.missed)
                {
                    return -1;
                }
            }
            return 0;
        }
    }

    class Program
    {
        static double Bet2Money(int bet)
        {
            if (bet < 0)
            {
                return 100.0 * 100.0 / Math.Abs((double)bet);
            }
            else
            {
                return bet;
            }
        }

        static void Main(string[] args)
        {
            //Make model input/output data
            Static.MakeTrainingData();

            //Resort data
            Resorter resorter = new Resorter();
            resorter.ReadData(@"..\..\..\data\Training-Data.csv");
            //comment out block below down to LABEL to compare with bagging
            resorter.Resort(1);
            resorter.Resort(2);
            resorter.Resort(3);
            resorter.Resort(5);
            resorter.Resort(7);
            resorter.Resort(11);
            resorter.Resort(13);
            resorter.Resort(17);
            //LABEL

            //Build ensemble by boosting
            Ensemble ensemble = new Ensemble(Resorter._inputs, Resorter._target);
            ensemble.BuildModels(23);

            //Prediction 
            List<TeamPerformance> perfomance_2018_2019_2020 = new List<TeamPerformance>();
            perfomance_2018_2019_2020.Add(new TeamPerformance("Manchester City", 32, 2, 95, 23));
            perfomance_2018_2019_2020.Add(new TeamPerformance("Liverpool", 30, 7, 89, 22));
            perfomance_2018_2019_2020.Add(new TeamPerformance("Chelsea", 21, 9, 63, 39));
            perfomance_2018_2019_2020.Add(new TeamPerformance("Tottenham", 23, 2, 67, 39));
            perfomance_2018_2019_2020.Add(new TeamPerformance("Arsenal", 21, 7, 73, 51));
            perfomance_2018_2019_2020.Add(new TeamPerformance("Manchester Utd", 19, 9, 65, 54));
            perfomance_2018_2019_2020.Add(new TeamPerformance("Wolves", 16, 9, 47, 46));
            perfomance_2018_2019_2020.Add(new TeamPerformance("Everton", 15, 9, 54, 46));
            perfomance_2018_2019_2020.Add(new TeamPerformance("Leicester", 15, 7, 51, 48));
            perfomance_2018_2019_2020.Add(new TeamPerformance("West Ham", 15, 7, 52, 55));
            perfomance_2018_2019_2020.Add(new TeamPerformance("Watford", 14, 8, 52, 59));
            perfomance_2018_2019_2020.Add(new TeamPerformance("Crystal Palace", 14, 7, 51, 53));
            perfomance_2018_2019_2020.Add(new TeamPerformance("Newcastle", 12, 9, 42, 48));
            perfomance_2018_2019_2020.Add(new TeamPerformance("Bournemouth", 13, 6, 56, 70));
            perfomance_2018_2019_2020.Add(new TeamPerformance("Burnley", 11, 7, 45, 68));
            perfomance_2018_2019_2020.Add(new TeamPerformance("Southampton", 9, 12, 45, 65));
            perfomance_2018_2019_2020.Add(new TeamPerformance("Brighton", 9, 9, 35, 60));
            perfomance_2018_2019_2020.Add(new TeamPerformance("Sheffield Utd", 10, 4, 34, 69)); //Cardiff
            perfomance_2018_2019_2020.Add(new TeamPerformance("Aston Villa", 7, 5, 34, 81)); //Fulham
            perfomance_2018_2019_2020.Add(new TeamPerformance("Norwich", 3, 7, 22, 76)); //Huddersfield

            perfomance_2018_2019_2020.Sort();

            DataReader dr = new DataReader();
            List<Game> previouslist = dr.ProcessFile("../../../DATA/2018-2019.txt");
            List<Game> currentlist = dr.ProcessFile("../../../DATA/2019-2020.txt");
 
            //replace relegations by new teams
            for (int i = 0; i < previouslist.Count; ++i)
            {
                if (previouslist[i].teamHome.Equals("Cardiff"))
                {
                    previouslist[i].teamHome = "Sheffield Utd";
                }
                if (previouslist[i].teamAway.Equals("Cardiff"))
                {
                    previouslist[i].teamAway = "Sheffield Utd";
                }
                if (previouslist[i].teamHome.Equals("Fulham"))
                {
                    previouslist[i].teamHome = "Aston Villa";
                }
                if (previouslist[i].teamAway.Equals("Fulham"))
                {
                    previouslist[i].teamAway = "Aston Villa";
                }
                if (previouslist[i].teamHome.Equals("Huddersfield"))
                {
                    previouslist[i].teamHome = "Norwich";
                }
                if (previouslist[i].teamAway.Equals("Huddersfield"))
                {
                    previouslist[i].teamAway = "Norwich";
                }
            }

            int counter = 0;
            int Total = 0;
            int Right = 0;
            double Amount = 0.0;
            Console.WriteLine("Prediction for British Premier League 2019-2020\n");
            foreach (Game current in currentlist)
            {
                int indexHome = -1;
                int indexAway = -1;
                for (int i = 0; i < perfomance_2018_2019_2020.Count; ++i)
                {
                    if (current.teamHome.Equals(perfomance_2018_2019_2020[i].name))
                    {
                        indexHome = i;
                    }
                    if (current.teamAway.Equals(perfomance_2018_2019_2020[i].name))
                    {
                        indexAway = i;
                    }
                }

                if (indexHome < 0 || indexAway < 0)
                {
                    current.ShowData();
                    Console.WriteLine("The team names are not in perfomance list");
                    Environment.Exit(0);
                }

                //here we apply model
                double[] sample = ensemble.GetOutput(new double[] { indexHome, indexAway });
                double NH = 0.0;
                double ND = 0.0;
                double NA = 0.0;
                for (int i = 0; i < sample.Length; ++i)  
                {
                    if (Math.Round(sample[i]) < 0.1 && Math.Round(sample[i]) > -0.1) ND += 1.0;
                    if (Math.Round(sample[i]) > 0.1) NH += 1.0;
                    if (Math.Round(sample[i]) < -0.1) NA += 1.0;
                }
                //Console.WriteLine("{0:0.0} {1:0.0} {2:0.0}", NH, ND, NA);

                int diff = current.goalsHome - current.goalsAway;
                string predicted_result = "game skipped";

                double PH = NH / (double)(sample.Length);
                double PD = ND / (double)(sample.Length);
                double PA = NA / (double)(sample.Length);

                double MH = PH * Bet2Money(current.Bet1) - (1.0 - PH) * 100.0;
                double MD = PD * Bet2Money(current.BetX) - (1.0 - PD) * 100.0;
                double MA = PA * Bet2Money(current.Bet2) - (1.0 - PA) * 100.0;

                //Console.WriteLine("{0:0.0} {1:0.0} {2:0.0}", MH, MD, MA);

                if (MH > MA && MH > MD)
                {
                    if (diff > 0)
                    {
                        Amount += Bet2Money(current.Bet1);
                        ++Right;
                        predicted_result = "right prediction";
                    }
                    else
                    {
                        Amount -= 100.0;
                        predicted_result = "wrong prediction";
                    }
                    ++Total;
                }
                if (MA > MH && MA > MD)
                {
                    if (diff < 0)
                    {
                        Amount += Bet2Money(current.Bet2);
                        ++Right;
                        predicted_result = "right prediction";
                    }
                    else
                    {
                        Amount -= 100.0;
                        predicted_result = "wrong prediction";
                    }
                    ++Total;
                }
                if (MD > MH && MD > MA) 
                {
                    if (0 == diff)
                    {
                        Amount += Bet2Money(current.BetX);
                        ++Right;
                        predicted_result = "right prediction";
                    }
                    else
                    {
                        Amount -= 100.0;
                        predicted_result = "wrong prediction";
                    }
                    ++Total;
                }

                Console.WriteLine("{0}. {1}, {2}", ++counter, current.GetGameInfo(), predicted_result);

                //update standings
                foreach (Game prev in previouslist)
                {
                    if (current.teamHome.Equals(prev.teamHome) && current.teamAway.Equals(prev.teamAway))
                    {
                        //prev.ShowData();
                        //current.ShowData();

                        for (int i = 0; i < perfomance_2018_2019_2020.Count; ++i)
                        {
                            //Update home
                            if (perfomance_2018_2019_2020[i].name.Equals(current.teamHome))
                            {
                                if (prev.goalsHome > prev.goalsAway)
                                {
                                    perfomance_2018_2019_2020[i].wins -= 1;
                                }
                                if (prev.goalsHome == prev.goalsAway)
                                {
                                    perfomance_2018_2019_2020[i].draws -= 1;
                                }
                                if (current.goalsHome > current.goalsAway)
                                {
                                    perfomance_2018_2019_2020[i].wins += 1;
                                }
                                if (current.goalsHome == current.goalsAway)
                                {
                                    perfomance_2018_2019_2020[i].draws += 1;
                                }
                                perfomance_2018_2019_2020[i].scored -= prev.goalsHome;
                                perfomance_2018_2019_2020[i].scored += current.goalsHome;
                                perfomance_2018_2019_2020[i].missed -= prev.goalsAway;
                                perfomance_2018_2019_2020[i].missed += current.goalsAway;
                            }

                            //Update away
                            if (perfomance_2018_2019_2020[i].name.Equals(current.teamAway))
                            {
                                if (prev.goalsAway > prev.goalsHome)
                                {
                                    perfomance_2018_2019_2020[i].wins -= 1;
                                }
                                if (prev.goalsHome == prev.goalsAway)
                                {
                                    perfomance_2018_2019_2020[i].draws -= 1;
                                }
                                if (current.goalsAway > current.goalsHome)
                                {
                                    perfomance_2018_2019_2020[i].wins += 1;
                                }
                                if (current.goalsHome == current.goalsAway)
                                {
                                    perfomance_2018_2019_2020[i].draws += 1;
                                }
                                perfomance_2018_2019_2020[i].missed -= prev.goalsHome;
                                perfomance_2018_2019_2020[i].missed += current.goalsHome;
                                perfomance_2018_2019_2020[i].scored -= prev.goalsAway;
                                perfomance_2018_2019_2020[i].scored += current.goalsAway;
                            }
                        }
                        break;
                    }
                }
                perfomance_2018_2019_2020.Sort();
                //end update standings
            }

            //Console.WriteLine("\nNew settings after the season");
            //foreach (TeamPerformance team in perfomance_2018_2019_2020)
            //{
            //    Console.WriteLine(team.name + " " + team.wins + " " + team.draws + " " + team.scored + " " + team.missed);
            //}

//Settings from OddsPortal.com
//1.Liverpool       32  3   85:33
//2.Manchester City 26  3  102:35
//3.Manchester Utd  18  12  66:36
//4.Chelsea         20  6   69:54 
//5.Leicester       18  8  67:41
//6.Tottenham       16  11  61:47
//7.Wolves          15  14  51:40
//8.Arsenal         14  14  56:48
//9.Sheffield Utd   14  12  39:39
//10.Burnley        15  9   43:50
//11.Southampton    15  7   51:60
//12.Everton        13  10  44:56
//13.Newcastle      11  11  38:58 
//14.Crystal Palace  11  10  31:50
//15.Brighton       9   14  39:54
//16.West Ham       10  9   49:62
//17.Aston Villa    9   8   41:67
//18.Bournemouth    9   7   40:65
//19.Watford        8   10  36:64
//20.Norwich        5   6   26:75

            Console.WriteLine("\nTotal bets {0}", Total);
            Console.WriteLine("Right predictions {0}", Right);
            Console.WriteLine("Total betting amount ${0}, $100 per game", Total * 100);
            Console.WriteLine("The end balance ${0:0.00}", Amount);
            Console.WriteLine("Winning to betting amount ratio {0:0.00}", Amount / (double)(Total) / 100.0);
        }
    }
}
