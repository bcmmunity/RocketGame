using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RocketGame.Models
{
    public class Setting
	{
		public int SettingId { get; set; }
		public int TimeTick { get; set; }
        public int TimeGame { get; set; }
		public DateTime GameEnd { get; set; }
        public int RocketSize { get; set; }
        public int RocketFuel { get; set; }
        public int TeamCount { get; set; }
        public int TeamSize { get; set; }
		public int TickPause { get; set; }
        public string Promo { get; set; }
        public bool IsStarted { get; set; }
		public bool IsPaused { get; set; }
        public bool IsFinished { get; set; }
    }
}
