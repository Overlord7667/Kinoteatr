﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinoteatr
{
    class KinoteatrFilm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Film> Films { get; set; }
    }
}
