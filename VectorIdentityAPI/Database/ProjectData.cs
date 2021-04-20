﻿using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VectorIdentityAPI.Database
{
    public class ProjectData
    {
        //file info
        public int Id { get; set; }
        public string Name { get; set; }
        public string FileType { get; set; }
        public byte[] FileData { get; set; }
        public DateTime DateCreated { get; set; }

        //status: new > processing > analysed
        public string Status { get; set; }
        public bool Original { get; set; }
        public double ScoreIdentity { get; set; }
        public double ScoreCorrectness { get; set; }

        public DateTime DateUploaded { get; set; }
        public DateTime DateUpdated { get; set; }

        [JsonIgnore] public int OwnerId { get; set; }
        [JsonIgnore] public User? Owner { get; set; }
        public int ProjectSetId { get; set; }
        [JsonIgnore] public ProjectSet ProjectSet { get; set; }


        [JsonIgnore] public ICollection<Line> Lines { get; set; }
        [JsonIgnore] public ICollection<Arc> Arcs { get; set; }

        //public ICollection<Match> Matches { get; set; }

    }
}
