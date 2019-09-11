using System;

namespace src.Models.Home
{
    public class IndexViewModel
    {
        public IndexViewModel(DateTime date, string ip)
        {
            Date = date;
            Ip = ip;
        }

        #region Properties

        public DateTime Date { get; set; }
        public string Ip { get; set; }

        #endregion Properties
    }
}