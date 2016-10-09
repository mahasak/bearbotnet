using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NBehave.Narrator.Framework;

namespace BearBot.Infrastructure.Bot.Control
{
    public class Actor
    {
        public string run(string features)
        {
            try
            {
                features.ExecuteText();
                return "success";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        
    }
}
