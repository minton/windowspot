using System;
using System.Drawing;
using System.IO;
using RestSharp;

namespace SpotSharp
{
    public class SpotClient : ISpotClient
    {
        readonly string _host;

        public SpotClient(string host)
        {
            _host = host;
        }

        public string Ping()
        {
            return Get("/").Content;
        }

        public string Playing()
        {
            return Get("/playing").Content;
        }

        public Image AlbumArt()
        {
            var bits = Get("/playing.png").RawBytes;
            return Image.FromStream(new MemoryStream(bits));
        }

        public string Find(string songName)
        {
            return Post("/find", new QueryParameter("q", songName)).Content;
        }

        public string Play()
        {
            return Put("/play").Content;
        }

        public string Pause()
        {
            return Put("/pause").Content;
        }

        public string Mute()
        {
            return Put("/mute").Content;
        }

        public string Volume()
        {
            return Get("/volume").Content;
        }

        public string SetVolume(int volume)
        {
            if (volume <0 || volume > 100)
                throw new ArgumentOutOfRangeException("volume");
            return Put("/volume", new QueryParameter("volume", volume)).Content;
        }

        public string Next()
        {
            return Put("/next").Content;
        }

        public string Back()
        {
            return Put("/back").Content;
        }

        public string Say(string what)
        {
            return Put("/say", new QueryParameter("what", what)).Content;
        }
        
        IRestResponse Get(string path)
        {
            return Request(path, Method.GET);
        }

        IRestResponse Post(string path, params QueryParameter[] queryParameters)
        {
            return Request(path, Method.POST, queryParameters);
        }

        IRestResponse Put(string path, params QueryParameter[] queryParameters)
        {
            return Request(path, Method.PUT, queryParameters);
        }

        IRestResponse Request(string path, Method method, params QueryParameter[] queryParameters)
        {
            var client = new RestClient(_host);
            var request = new RestRequest(path, method);
            if (queryParameters != null)
            {
                foreach (var parameter in queryParameters)
                {
                    request.AddParameter(parameter.Name, parameter.Value);
                }
            }
            return client.Execute(request);
        }
    }

    public class QueryParameter
    {
        public string Name { get; private set; }
        public object Value { get; private set; }

        public QueryParameter(string name, object value)
        {
            Name = name;
            Value = value;
        }
    }
}
