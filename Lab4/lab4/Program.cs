using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Authenticators;
using Microsoft.EntityFrameworkCore;
//using Newtonsoft.Json;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text.Json;

namespace lab4
{
    class Program
    {

        static async Task Main(string[] args)
        {
            #region RestSharp WEBSITE READING
            //var sw = new Stopwatch();

            //var google = new Website("https://google.pl");
            //var ath = new Website("https://ath.bielsko.pl");
            //var fb = new Website("https://www.facebook.com/");
            //var wiki = new Website("https://www.wikipedia.org/");
            //var anyapi = new Website("https://www.any-api.com/");

            //var tasks = new List<Task>();

            //sw.Start();
            //Console.WriteLine(await google.DownloadAsync("/"));
            //Console.WriteLine(sw.Elapsed);
            //Console.WriteLine(await ath.DownloadAsync("/"));
            //Console.WriteLine(sw.Elapsed);
            //Console.WriteLine(await fb.DownloadAsync("/"));
            //Console.WriteLine(sw.Elapsed);
            //Console.WriteLine(await wiki.DownloadAsync("/wiki/.NET_Core"));
            //Console.WriteLine(sw.Elapsed);
            //Console.WriteLine(await anyapi.DownloadAsync("/wiki/.NET_Core"));
            //Console.WriteLine(sw.Elapsed);

            //Console.WriteLine(google.DownloadAsync("/").Result);
            //Console.WriteLine(sw.Elapsed);
            //Console.WriteLine(ath.DownloadAsync("/").Result);
            //Console.WriteLine(sw.Elapsed);
            //Console.WriteLine(fb.DownloadAsync("/").Result);
            //Console.WriteLine(sw.Elapsed);
            //Console.WriteLine(wiki.DownloadAsync("/wiki/.NET_Core").Result);
            //Console.WriteLine(sw.Elapsed);
            //Console.WriteLine(anyapi.DownloadAsync("/wiki/.NET_Core").Result);
            //Console.WriteLine(sw.Elapsed);

            //tasks.Add(google.DownloadAsync("/"));
            //Console.WriteLine(sw.Elapsed);
            //tasks.Add(ath.DownloadAsync("/"));
            //Console.WriteLine(sw.Elapsed);
            //tasks.Add(fb.DownloadAsync("/"));
            //Console.WriteLine(sw.Elapsed);
            //tasks.Add(wiki.DownloadAsync("/wiki/.NET_Core"));
            //Console.WriteLine(sw.Elapsed);
            //tasks.Add(anyapi.DownloadAsync("/wiki/.NET_Core"));
            //Console.WriteLine(sw.Elapsed);

            //Console.WriteLine("---------------------");
            ////Console.WriteLine(Task.WhenAny(tasks).Result);
            //Console.WriteLine(sw.Elapsed);
            //var htmlCode = Task.WhenAll(tasks);
            //Console.WriteLine(sw.Elapsed);
            //sw.Stop();xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
            #endregion

            #region API TEAMS W
            using var context = new TeamsContext();
            context.Database.EnsureCreated();

            var api = new RestClient("https://api.collegefootballdata.com/");
            var teamsData = new RestRequest($"/teams/fbs?year=2019", Method.GET);
            var response = await api.ExecuteAsync(teamsData);
            var content = response.Content;
            var teams = JsonSerializer.Deserialize<Team[]>(content, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
            var tasks = new List<Task<IRestResponse>>();
            foreach (var team in teams)
            {
                var coachRequest = new RestRequest($"/coaches?team={team.School}&year=2019", Method.GET);
                tasks.Add(api.ExecuteAsync(coachRequest));
            }
            var responses = await Task.WhenAll(tasks);
            var coaches = responses.SelectMany(x => JsonSerializer.Deserialize<Coach[]>(x.Content,new JsonSerializerOptions() { PropertyNameCaseInsensitive = true}));

            foreach (var coach in coaches)
            {
                teams.Single(x =>
                x.School == coach.Seasons.First().School)
                .Coaches.Add(coach);
            }

            var addTasks = teams.Select(x => context.AddAsync(x).AsTask());
            await Task.WhenAll(addTasks);
            await context.SaveChangesAsync();
            #endregion

            #region API TEAMS NW
            //var api = new Website("https://api.collegefootballdata.com/");
            //var sourceTeams = api.Download($"/teams/fbs?year=2019");
            //sourceTeams = sourceTeams.Remove(0, 1);
            //sourceTeams = sourceTeams.Remove(sourceTeams.Length - 1, 1);
            //string[] teams = sourceTeams.Split('{', '}');
            //var stringToObj = teams.Where(n => !(string.IsNullOrEmpty(n) || n == ",")).ToArray();
            //using var context = new TeamsContext();
            //var tasks = new List<Task<IRestResponse>>();
            //for (int i = 0; i < stringToObj.Length; i++)
            //{
            //    stringToObj[i] = $"{{{stringToObj[i]}}}";
            //    var bufor = JsonConvert.DeserializeObject<Team>(stringToObj[i]);
            //    var dataCoaches = api.Download($"/coaches?team={bufor.School}&year=2019");
            //    dataCoaches = dataCoaches.Remove(0, 1);
            //    dataCoaches = dataCoaches.Remove(dataCoaches.Length - 1, 1);
            //    Console.WriteLine(dataCoaches);
            //    var bufor2 = JsonConvert.DeserializeObject<Coach>(dataCoaches);
            //    //Console.WriteLine(bufor2.First_name,bufor2.Seasons);
            //}
            //context.SaveChanges();
            #endregion
        }
    }
}
