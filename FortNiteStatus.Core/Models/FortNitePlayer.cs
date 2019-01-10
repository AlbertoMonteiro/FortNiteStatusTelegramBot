using System;

namespace FortNiteStatus.Core.Models
{
    public class FortNitePlayer
    {
        public string accountId { get; set; }
        public int platformId { get; set; }
        public string platformName { get; set; }
        public string platformNameLong { get; set; }
        public string epicUserHandle { get; set; }
        public Stats stats { get; set; }
        public Lifetimestat[] lifeTimeStats { get; set; }
        public Recentmatch[] recentMatches { get; set; }
    }

    public class Stats
    {
        public P2 p2 { get; set; }
        public P10 p10 { get; set; }
        public P9 p9 { get; set; }
        public Curr_P2 curr_p2 { get; set; }
        public Curr_P10 curr_p10 { get; set; }
        public Curr_P9 curr_p9 { get; set; }
    }

    public class P2
    {
        public Trnrating trnRating { get; set; }
        public Score score { get; set; }
        public Top1 top1 { get; set; }
        public Top3 top3 { get; set; }
        public Top5 top5 { get; set; }
        public Top6 top6 { get; set; }
        public Top10 top10 { get; set; }
        public Top12 top12 { get; set; }
        public Top25 top25 { get; set; }
        public Kd kd { get; set; }
        public Winratio winRatio { get; set; }
        public Matches matches { get; set; }
        public Kills kills { get; set; }
        public Kpg kpg { get; set; }
        public Scorepermatch scorePerMatch { get; set; }
    }

    public class Trnrating
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public int valueInt { get; set; }
        public string value { get; set; }
        public float percentile { get; set; }
        public string displayValue { get; set; }
    }

    public class Score
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public int valueInt { get; set; }
        public string value { get; set; }
        public float percentile { get; set; }
        public string displayValue { get; set; }
    }

    public class Top1
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public int valueInt { get; set; }
        public string value { get; set; }
        public float percentile { get; set; }
        public string displayValue { get; set; }
    }

    public class Top3
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public int valueInt { get; set; }
        public string value { get; set; }
        public string displayValue { get; set; }
    }

    public class Top5
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public int valueInt { get; set; }
        public string value { get; set; }
        public string displayValue { get; set; }
    }

    public class Top6
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public int valueInt { get; set; }
        public string value { get; set; }
        public string displayValue { get; set; }
    }

    public class Top10
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public int valueInt { get; set; }
        public string value { get; set; }
        public float percentile { get; set; }
        public string displayValue { get; set; }
    }

    public class Top12
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public int valueInt { get; set; }
        public string value { get; set; }
        public string displayValue { get; set; }
    }

    public class Top25
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public int valueInt { get; set; }
        public string value { get; set; }
        public float percentile { get; set; }
        public string displayValue { get; set; }
    }

    public class Kd
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public float valueDec { get; set; }
        public string value { get; set; }
        public float percentile { get; set; }
        public string displayValue { get; set; }
    }

    public class Winratio
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public float valueDec { get; set; }
        public string value { get; set; }
        public float percentile { get; set; }
        public string displayValue { get; set; }
    }

    public class Matches
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public int valueInt { get; set; }
        public string value { get; set; }
        public float percentile { get; set; }
        public string displayValue { get; set; }
    }

    public class Kills
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public int valueInt { get; set; }
        public string value { get; set; }
        public float percentile { get; set; }
        public string displayValue { get; set; }
    }

    public class Kpg
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public float valueDec { get; set; }
        public string value { get; set; }
        public float percentile { get; set; }
        public string displayValue { get; set; }
    }

    public class Scorepermatch
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public float valueDec { get; set; }
        public string value { get; set; }
        public float percentile { get; set; }
        public string displayValue { get; set; }
    }

    public class P10
    {
        public Trnrating1 trnRating { get; set; }
        public Score1 score { get; set; }
        public Top11 top1 { get; set; }
        public Top31 top3 { get; set; }
        public Top51 top5 { get; set; }
        public Top61 top6 { get; set; }
        public Top101 top10 { get; set; }
        public Top121 top12 { get; set; }
        public Top251 top25 { get; set; }
        public Kd1 kd { get; set; }
        public Winratio1 winRatio { get; set; }
        public Matches1 matches { get; set; }
        public Kills1 kills { get; set; }
        public Kpg1 kpg { get; set; }
        public Scorepermatch1 scorePerMatch { get; set; }
    }

    public class Trnrating1
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public int valueInt { get; set; }
        public string value { get; set; }
        public float percentile { get; set; }
        public string displayValue { get; set; }
    }

    public class Score1
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public int valueInt { get; set; }
        public string value { get; set; }
        public float percentile { get; set; }
        public string displayValue { get; set; }
    }

    public class Top11
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public int valueInt { get; set; }
        public string value { get; set; }
        public float percentile { get; set; }
        public string displayValue { get; set; }
    }

    public class Top31
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public int valueInt { get; set; }
        public string value { get; set; }
        public string displayValue { get; set; }
    }

    public class Top51
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public int valueInt { get; set; }
        public string value { get; set; }
        public float percentile { get; set; }
        public string displayValue { get; set; }
    }

    public class Top61
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public int valueInt { get; set; }
        public string value { get; set; }
        public string displayValue { get; set; }
    }

    public class Top101
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public int valueInt { get; set; }
        public string value { get; set; }
        public string displayValue { get; set; }
    }

    public class Top121
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public int valueInt { get; set; }
        public string value { get; set; }
        public float percentile { get; set; }
        public string displayValue { get; set; }
    }

    public class Top251
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public int valueInt { get; set; }
        public string value { get; set; }
        public string displayValue { get; set; }
    }

    public class Kd1
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public float valueDec { get; set; }
        public string value { get; set; }
        public float percentile { get; set; }
        public string displayValue { get; set; }
    }

    public class Winratio1
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public float valueDec { get; set; }
        public string value { get; set; }
        public float percentile { get; set; }
        public string displayValue { get; set; }
    }

    public class Matches1
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public int valueInt { get; set; }
        public string value { get; set; }
        public float percentile { get; set; }
        public string displayValue { get; set; }
    }

    public class Kills1
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public int valueInt { get; set; }
        public string value { get; set; }
        public float percentile { get; set; }
        public string displayValue { get; set; }
    }

    public class Kpg1
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public float valueDec { get; set; }
        public string value { get; set; }
        public float percentile { get; set; }
        public string displayValue { get; set; }
    }

    public class Scorepermatch1
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public float valueDec { get; set; }
        public string value { get; set; }
        public float percentile { get; set; }
        public string displayValue { get; set; }
    }

    public class P9
    {
        public Trnrating2 trnRating { get; set; }
        public Score2 score { get; set; }
        public Top13 top1 { get; set; }
        public Top32 top3 { get; set; }
        public Top52 top5 { get; set; }
        public Top62 top6 { get; set; }
        public Top102 top10 { get; set; }
        public Top122 top12 { get; set; }
        public Top252 top25 { get; set; }
        public Kd2 kd { get; set; }
        public Winratio2 winRatio { get; set; }
        public Matches2 matches { get; set; }
        public Kills2 kills { get; set; }
        public Kpg2 kpg { get; set; }
        public Scorepermatch2 scorePerMatch { get; set; }
    }

    public class Trnrating2
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public int valueInt { get; set; }
        public string value { get; set; }
        public float percentile { get; set; }
        public string displayValue { get; set; }
    }

    public class Score2
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public int valueInt { get; set; }
        public string value { get; set; }
        public float percentile { get; set; }
        public string displayValue { get; set; }
    }

    public class Top13
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public int valueInt { get; set; }
        public string value { get; set; }
        public float percentile { get; set; }
        public string displayValue { get; set; }
    }

    public class Top32
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public int valueInt { get; set; }
        public string value { get; set; }
        public float percentile { get; set; }
        public string displayValue { get; set; }
    }

    public class Top52
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public int valueInt { get; set; }
        public string value { get; set; }
        public string displayValue { get; set; }
    }

    public class Top62
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public int valueInt { get; set; }
        public string value { get; set; }
        public float percentile { get; set; }
        public string displayValue { get; set; }
    }

    public class Top102
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public int valueInt { get; set; }
        public string value { get; set; }
        public string displayValue { get; set; }
    }

    public class Top122
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public int valueInt { get; set; }
        public string value { get; set; }
        public string displayValue { get; set; }
    }

    public class Top252
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public int valueInt { get; set; }
        public string value { get; set; }
        public string displayValue { get; set; }
    }

    public class Kd2
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public float valueDec { get; set; }
        public string value { get; set; }
        public float percentile { get; set; }
        public string displayValue { get; set; }
    }

    public class Winratio2
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public float valueDec { get; set; }
        public string value { get; set; }
        public float percentile { get; set; }
        public string displayValue { get; set; }
    }

    public class Matches2
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public int valueInt { get; set; }
        public string value { get; set; }
        public float percentile { get; set; }
        public string displayValue { get; set; }
    }

    public class Kills2
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public int valueInt { get; set; }
        public string value { get; set; }
        public float percentile { get; set; }
        public string displayValue { get; set; }
    }

    public class Kpg2
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public float valueDec { get; set; }
        public string value { get; set; }
        public float percentile { get; set; }
        public string displayValue { get; set; }
    }

    public class Scorepermatch2
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public float valueDec { get; set; }
        public string value { get; set; }
        public float percentile { get; set; }
        public string displayValue { get; set; }
    }

    public class Curr_P2
    {
        public Trnrating3 trnRating { get; set; }
        public Score3 score { get; set; }
        public Top14 top1 { get; set; }
        public Top33 top3 { get; set; }
        public Top53 top5 { get; set; }
        public Top63 top6 { get; set; }
        public Top103 top10 { get; set; }
        public Top123 top12 { get; set; }
        public Top253 top25 { get; set; }
        public Kd3 kd { get; set; }
        public Winratio3 winRatio { get; set; }
        public Matches3 matches { get; set; }
        public Kills3 kills { get; set; }
        public Kpg3 kpg { get; set; }
        public Scorepermatch3 scorePerMatch { get; set; }
    }

    public class Trnrating3
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public int valueInt { get; set; }
        public string value { get; set; }
        public float percentile { get; set; }
        public string displayValue { get; set; }
    }

    public class Score3
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public int valueInt { get; set; }
        public string value { get; set; }
        public float percentile { get; set; }
        public string displayValue { get; set; }
    }

    public class Top14
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public int valueInt { get; set; }
        public string value { get; set; }
        public float percentile { get; set; }
        public string displayValue { get; set; }
    }

    public class Top33
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public int valueInt { get; set; }
        public string value { get; set; }
        public string displayValue { get; set; }
    }

    public class Top53
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public int valueInt { get; set; }
        public string value { get; set; }
        public string displayValue { get; set; }
    }

    public class Top63
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public int valueInt { get; set; }
        public string value { get; set; }
        public string displayValue { get; set; }
    }

    public class Top103
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public int valueInt { get; set; }
        public string value { get; set; }
        public float percentile { get; set; }
        public string displayValue { get; set; }
    }

    public class Top123
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public int valueInt { get; set; }
        public string value { get; set; }
        public string displayValue { get; set; }
    }

    public class Top253
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public int valueInt { get; set; }
        public string value { get; set; }
        public float percentile { get; set; }
        public string displayValue { get; set; }
    }

    public class Kd3
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public float valueDec { get; set; }
        public string value { get; set; }
        public float percentile { get; set; }
        public string displayValue { get; set; }
    }

    public class Winratio3
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public float valueDec { get; set; }
        public string value { get; set; }
        public float percentile { get; set; }
        public string displayValue { get; set; }
    }

    public class Matches3
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public int valueInt { get; set; }
        public string value { get; set; }
        public float percentile { get; set; }
        public string displayValue { get; set; }
    }

    public class Kills3
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public int valueInt { get; set; }
        public string value { get; set; }
        public float percentile { get; set; }
        public string displayValue { get; set; }
    }

    public class Kpg3
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public float valueDec { get; set; }
        public string value { get; set; }
        public float percentile { get; set; }
        public string displayValue { get; set; }
    }

    public class Scorepermatch3
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public float valueDec { get; set; }
        public string value { get; set; }
        public float percentile { get; set; }
        public string displayValue { get; set; }
    }

    public class Curr_P10
    {
        public Trnrating4 trnRating { get; set; }
        public Score4 score { get; set; }
        public Top15 top1 { get; set; }
        public Top34 top3 { get; set; }
        public Top54 top5 { get; set; }
        public Top64 top6 { get; set; }
        public Top104 top10 { get; set; }
        public Top124 top12 { get; set; }
        public Top254 top25 { get; set; }
        public Kd4 kd { get; set; }
        public Winratio4 winRatio { get; set; }
        public Matches4 matches { get; set; }
        public Kills4 kills { get; set; }
        public Kpg4 kpg { get; set; }
        public Scorepermatch4 scorePerMatch { get; set; }
    }

    public class Trnrating4
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public int valueInt { get; set; }
        public string value { get; set; }
        public float percentile { get; set; }
        public string displayValue { get; set; }
    }

    public class Score4
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public int valueInt { get; set; }
        public string value { get; set; }
        public float percentile { get; set; }
        public string displayValue { get; set; }
    }

    public class Top15
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public int valueInt { get; set; }
        public string value { get; set; }
        public string displayValue { get; set; }
    }

    public class Top34
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public int valueInt { get; set; }
        public string value { get; set; }
        public string displayValue { get; set; }
    }

    public class Top54
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public int valueInt { get; set; }
        public string value { get; set; }
        public float percentile { get; set; }
        public string displayValue { get; set; }
    }

    public class Top64
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public int valueInt { get; set; }
        public string value { get; set; }
        public string displayValue { get; set; }
    }

    public class Top104
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public int valueInt { get; set; }
        public string value { get; set; }
        public string displayValue { get; set; }
    }

    public class Top124
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public int valueInt { get; set; }
        public string value { get; set; }
        public float percentile { get; set; }
        public string displayValue { get; set; }
    }

    public class Top254
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public int valueInt { get; set; }
        public string value { get; set; }
        public string displayValue { get; set; }
    }

    public class Kd4
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public float valueDec { get; set; }
        public string value { get; set; }
        public float percentile { get; set; }
        public string displayValue { get; set; }
    }

    public class Winratio4
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public float valueDec { get; set; }
        public string value { get; set; }
        public string displayValue { get; set; }
    }

    public class Matches4
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public int valueInt { get; set; }
        public string value { get; set; }
        public float percentile { get; set; }
        public string displayValue { get; set; }
    }

    public class Kills4
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public int valueInt { get; set; }
        public string value { get; set; }
        public float percentile { get; set; }
        public string displayValue { get; set; }
    }

    public class Kpg4
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public float valueDec { get; set; }
        public string value { get; set; }
        public float percentile { get; set; }
        public string displayValue { get; set; }
    }

    public class Scorepermatch4
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public float valueDec { get; set; }
        public string value { get; set; }
        public float percentile { get; set; }
        public string displayValue { get; set; }
    }

    public class Curr_P9
    {
        public Trnrating5 trnRating { get; set; }
        public Score5 score { get; set; }
        public Top16 top1 { get; set; }
        public Top35 top3 { get; set; }
        public Top55 top5 { get; set; }
        public Top65 top6 { get; set; }
        public Top105 top10 { get; set; }
        public Top125 top12 { get; set; }
        public Top255 top25 { get; set; }
        public Kd5 kd { get; set; }
        public Winratio5 winRatio { get; set; }
        public Matches5 matches { get; set; }
        public Kills5 kills { get; set; }
        public Kpg5 kpg { get; set; }
        public Scorepermatch5 scorePerMatch { get; set; }
    }

    public class Trnrating5
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public int valueInt { get; set; }
        public string value { get; set; }
        public float percentile { get; set; }
        public string displayValue { get; set; }
    }

    public class Score5
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public int valueInt { get; set; }
        public string value { get; set; }
        public float percentile { get; set; }
        public string displayValue { get; set; }
    }

    public class Top16
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public int valueInt { get; set; }
        public string value { get; set; }
        public float percentile { get; set; }
        public string displayValue { get; set; }
    }

    public class Top35
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public int valueInt { get; set; }
        public string value { get; set; }
        public float percentile { get; set; }
        public string displayValue { get; set; }
    }

    public class Top55
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public int valueInt { get; set; }
        public string value { get; set; }
        public string displayValue { get; set; }
    }

    public class Top65
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public int valueInt { get; set; }
        public string value { get; set; }
        public float percentile { get; set; }
        public string displayValue { get; set; }
    }

    public class Top105
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public int valueInt { get; set; }
        public string value { get; set; }
        public string displayValue { get; set; }
    }

    public class Top125
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public int valueInt { get; set; }
        public string value { get; set; }
        public string displayValue { get; set; }
    }

    public class Top255
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public int valueInt { get; set; }
        public string value { get; set; }
        public string displayValue { get; set; }
    }

    public class Kd5
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public float valueDec { get; set; }
        public string value { get; set; }
        public float percentile { get; set; }
        public string displayValue { get; set; }
    }

    public class Winratio5
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public float valueDec { get; set; }
        public string value { get; set; }
        public float percentile { get; set; }
        public string displayValue { get; set; }
    }

    public class Matches5
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public int valueInt { get; set; }
        public string value { get; set; }
        public float percentile { get; set; }
        public string displayValue { get; set; }
    }

    public class Kills5
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public int valueInt { get; set; }
        public string value { get; set; }
        public float percentile { get; set; }
        public string displayValue { get; set; }
    }

    public class Kpg5
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public float valueDec { get; set; }
        public string value { get; set; }
        public float percentile { get; set; }
        public string displayValue { get; set; }
    }

    public class Scorepermatch5
    {
        public string label { get; set; }
        public string field { get; set; }
        public string category { get; set; }
        public float valueDec { get; set; }
        public string value { get; set; }
        public float percentile { get; set; }
        public string displayValue { get; set; }
    }

    public class Lifetimestat
    {
        public string key { get; set; }
        public string value { get; set; }
    }

    public class Recentmatch
    {
        public int id { get; set; }
        public string accountId { get; set; }
        public string playlist { get; set; }
        public int kills { get; set; }
        public int minutesPlayed { get; set; }
        public int top1 { get; set; }
        public int top5 { get; set; }
        public int top6 { get; set; }
        public int top10 { get; set; }
        public int top12 { get; set; }
        public int top25 { get; set; }
        public int matches { get; set; }
        public int top3 { get; set; }
        public DateTime dateCollected { get; set; }
        public int score { get; set; }
        public int platform { get; set; }
        public float trnRating { get; set; }
        public float trnRatingChange { get; set; }
    }
}
