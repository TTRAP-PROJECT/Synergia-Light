﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstMobileApp.Class
{
    public class EvenementsSportifs
    {
        public int IdService { get; set; }
        public string LibelleSport { get; set; }
        public string LieuEvent { get; set; }
        public DateTime DateEvent { get; set; }
        public int NombreDeReservations { get; set; }
        [JsonProperty("s_e_r_v_i_c_e")]
        public Services Service { get; set; }
    }
}
