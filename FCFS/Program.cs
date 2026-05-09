using System;
using System.Collections.Generic;

class Process
{
    public int Id { get; set; }
    public int BurstTime { get; set; }
}

class FCFS
{
    static void Main()
    {
        List<Process> processes = new List<Process>()
        {
            new Process { Id = 1 , BurstTime = 5 },
            new Process { Id = 2 , BurstTime = 3 },
            new Process { Id = 3 , BurstTime = 8 },
            new Process { Id = 4 , BurstTime = 1 }
        };

        int waitingTime = 0;

        Console.WriteLine("FCFS Scheduling:\n");

        foreach (var process in processes)
        {
            Console.WriteLine(
                $"Process P{process.Id} | Burst Time: {process.BurstTime} | Waiting Time: {waitingTime}");

            waitingTime += process.BurstTime;
        }
    }
}