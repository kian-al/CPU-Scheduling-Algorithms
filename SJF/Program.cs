using System;
using System.Collections.Generic;
using System.Linq;

class Process
{
    public int Id { get; set; }
    public float BurstTime { get; set; }
}

class SJF
{
    static void Main()
    {
        List<Process> processes = new List<Process>()
        {
            new Process { Id = 1 , BurstTime = 2 },
            new Process { Id = 2 , BurstTime = 2.1f },
            new Process { Id = 3 , BurstTime = 8 },
            new Process { Id = 4 , BurstTime = 3 },
            new Process { Id = 5 , BurstTime = 1 }

        };

        var sortedProcesses = processes.OrderBy(p => p.BurstTime).ToList();

        float waitingTime = 0;

        Console.WriteLine("SJF Scheduling:\n");

        foreach (var process in sortedProcesses)
        {
            Console.WriteLine(
                $"Process P{process.Id} | Burst Time: {process.BurstTime} | Waiting Time: {waitingTime}");

            waitingTime += process.BurstTime;
        }
    }
}