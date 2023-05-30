using CustomerCall;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppCustomerCall.Data
{
    public static class CallPlansInit
    {
        //public static List<CallPlan> tPans 
        //{
        //    get
        //    {
        //        return new List<CallPlan> {
        //       new CallPlanSimple(),
        //          new CallPlanFree2andMinuteAfter10(),
        //            new CallPlanTwiceCheaperFirst5Minutes(5) };
        //    }
        //}

        public static List<CallPlan> tPans => new List<CallPlan> {
               new CallPlanSimple(),
                  new CallPlanFree2andMinuteAfter10(),
                    new CallPlanTwiceCheaperFirst5Minutes(5) };
    }
}
