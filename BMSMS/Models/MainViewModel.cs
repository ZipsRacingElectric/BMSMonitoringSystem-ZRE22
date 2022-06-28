﻿using BMSMS.CAN;
using BMSMS.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using Windows.UI.Core;

namespace BMSMS.Models
{
    public class MainViewModel
    {
        public static int totalCells = 90;
        public static int totalThermistors = 45;

        public static double thermistorScale = -21.933;
        public static double thermistorOffset = 81.29697;

        public double stateOfCharge;

        public double current;
        public double highCurrent;

        public double totalVoltage;

        public double highestTemp;

        public double[] CellVoltages = new double[totalCells];

        public int[] CellBalancing = new int[totalCells];

        public double[] Temperatures = new double[totalThermistors];

        public string CANState = CANToolState.Disconnected;

        public bool ToolConnected = false;

        public bool IsPaused = false;

        public bool MessageReceived = false;

        public bool voltageFault = false;
        public bool tempFault = false;
        public bool selfTestFail = false;
        public bool overCurrent = false;
        public bool senseLineOverCurrent = false;

        public string Log = "";
        public string StaticLog = "";

        public Windows.Storage.StorageFile logFile = null;

        public static SortedDictionary<int, CANMessage> CanMessages = new SortedDictionary<int, CANMessage>();

        public static Semaphore _pool = new Semaphore(1, 1);
    }
}
