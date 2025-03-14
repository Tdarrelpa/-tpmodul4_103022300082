﻿// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics;
/*
public class KodePos
{
     referensi: https://docs.microsoft.com/en-us/dotnet/api/system.stringcomparison?view=net-6.0
     public enum StringComparison{CurrentCulture = 0, CurrentCultureIgnoreCase = 1, InvariantCulture = 2, InvariantCultureIgnoreCase = 3, Ordinal = 4, OrdinalIgnoreCase = 5};
    public static void Main(string[] args)
    {
        string kelurahan = Console.ReadLine();
        Console.WriteLine("Kode pos: " + GetKodePos(kelurahan));
    }

    public static int GetKodePos(string namaKelurahan)
    {
        string[] kelurahan = { "Batununggal", "Kujangsari", "Mengger", "Wates", "Cijaura", "Jatisari", "Margasari", "Sekejati", "Kebonwaru", "Maleer", "Samoja" };
        int[] kodePos = { 40266, 40287, 40267, 40256, 40287, 40286, 40286, 40286, 40272, 40274, 40273 };

        for (int tingkatKodePos = 0; tingkatKodePos < kodePos.Length; tingkatKodePos++)
        {
            if (kelurahan[tingkatKodePos].Equals(namaKelurahan, StringComparison.OrdinalIgnoreCase))
            {
                return kodePos[tingkatKodePos];
            }
        }
        // Return -1 if no match is found
        return -1;
    }
}
*/

public class DoorMachine
{
    public enum State{LOCKED, UNLOCKED};
    public State currentState;

    public DoorMachine()
    {
        currentState = State.LOCKED;
    }

    public static void Main(string[] args) 
    {
        DoorMachine doorMachine = new DoorMachine();
        string command;
        do
        {
            Console.Write("Enter Command (UNLOCK/LOCK/EXIT): ");
            command = Console.ReadLine();

            if (command.ToUpper() == "UNLOCK")
            {
                doorMachine.Unlock();
            }
            else if (command.ToUpper() == "LOCK")
            {
                doorMachine.Lock();
            }
            else if (command.ToUpper() == "EXIT")
            {
                break;
            }
        } while (command.ToUpper() != "EXIT");
    }

    public void Unlock()
    {
        if (currentState == State.LOCKED)
        {
            currentState = State.UNLOCKED;
            Console.WriteLine("Pintu tidak terkunci");
        }
    }

    public void Lock()
    {
        if (currentState == State.UNLOCKED)
        {
            currentState = State.LOCKED;
            Console.WriteLine("Pintu terkunci");
        }
    }
}