using System;
using System.Collections.Generic;

class Process
{
    public int Id { get; set; }
    public int BurstTime { get; set; }
}

class RoundRobin
{
    static void Main()
    {
        Queue<Process> queue = new Queue<Process>();

        queue.Enqueue(new Process { Id = 1, BurstTime = 10 });
        queue.Enqueue(new Process { Id = 2, BurstTime = 5 });
        queue.Enqueue(new Process { Id = 3, BurstTime = 8 });

        int quantum = 2;

        Console.WriteLine("Round Robin Scheduling:\n");

        while (queue.Count > 0)
        {
            Process current = queue.Dequeue();

            if (current.BurstTime > quantum)
            {
                Console.WriteLine(
                    $"Process P{current.Id} executed for {quantum}");

                current.BurstTime -= quantum;

                queue.Enqueue(current);
            }
            else
            {
                Console.WriteLine(
                    $"Process P{current.Id} completed");
            }
        }
    }
}