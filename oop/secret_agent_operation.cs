using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    //1
    internal class Agent
    {
        private string CodeName;
        private int ClearanceLevel;

        public Agent(string CodeName , int ClearanceLevel)
        {
            this.CodeName = CodeName;
            this.ClearanceLevel = ClearanceLevel;
        }

        public string GetCodeName()
        {
            return this.CodeName;
        }

        public int GetClearanceLevel()
        {
            return this.ClearanceLevel;
        }

        public void SetClearanceLevel(int level)
        {
            if(level<1 && level > 5)
            {
                this.ClearanceLevel = level;
            }
        }

        public void Report()
        {
            Console.WriteLine($"Agent {this.CodeName} reporting. Clearance Level: { this.ClearanceLevel}");
        }
    }

    //2
    class Mission
    {
        private string MissionName;
        private string TargetLocation;
        private Agent AssignedAgent;

        public Mission(string MissionName, string TargetLocation, Agent AssignedAgent)
        {
            this.MissionName = MissionName;
            this.TargetLocation = TargetLocation;
            this.AssignedAgent = AssignedAgent;
        }

        public void Brief()
        {
            Console.WriteLine($"Mission: {this.MissionName}, Target: {this.TargetLocation}, Agent: {this.AssignedAgent.GetCodeName()}");
        }
    }

    

    //4
    static class IntelTools
    {

        public static string EncryptMessage(string msg)
        {
            string reversed_str = "";
            for(int i=msg.Length; i>-1; i--)
            {
                reversed_str += msg[i];
            }
            return reversed_str;
        }

        public static void LogTransmission(string agentName, string message)
        {
            Console.WriteLine($"{agentName} sent encrypted message: {message}");
        }

    }

    class Report
    {
        private int Summary;
        private int UrgencyLevel;
        private Agent SubmittedBy;

        public Report(int Summary, int UrgencyLevel, Agent SubmittedBy)
        {
            this.Summary = Summary;
            this.UrgencyLevel = UrgencyLevel;
            this.SubmittedBy = SubmittedBy;
        }

        public int GetUrgencyLevel()
        {
            return this.UrgencyLevel;
        }
    }


    static class MissionControl
    {
        static public void AnalyzeReport(Report r)
        {
            if(r.GetUrgencyLevel() >= 4)
            {
                Console.WriteLine("Immediate response required.");
            }
            else if(r.GetUrgencyLevel() == 3)
            {
                Console.WriteLine("High priority. Monitor closely.");
            }
            else
            {
                Console.WriteLine("Routine analysis.");
            }
        }
    }
}
