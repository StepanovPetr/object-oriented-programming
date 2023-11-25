using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;

namespace LibExample
{
    public class WindowsCmdManager
    {
        private List<string> _tracertTable;
        private List<string> _tracertArp;
        private int _tracertInteration = 0;

      
        private int _arpInteration = 0;

        /// <summary> Получение таблицы маршрутизации через cmd. </summary>
        /// <param name="gateway"> IP адрес шлюза по-умолчанию. </param>
        /// <returns> таблицы прассеровки. </returns>
        public IEnumerable<string> GetTracertTable(string gateway)
        {
            _tracertInteration = 0;
            _tracertTable = new List<string>();
            Process cmdProcess = new Process();
            cmdProcess.StartInfo = CreateProcessStartInfo("tracert", gateway);
            cmdProcess.OutputDataReceived += ParseTracert;
            cmdProcess.EnableRaisingEvents = true;
            cmdProcess.Start();
            cmdProcess.BeginOutputReadLine();
            cmdProcess.WaitForExit();

            return _tracertTable;
        }

        /// <summary> Получение arp таблицы через cmd. </summary>
        /// <returns> arp таблица. </returns>
        public IEnumerable<string> GetArpTable()
        {
            _arpInteration = 0;
            _tracertArp = new List<string>();
            Process cmdProcess = new Process();
            cmdProcess.StartInfo = CreateProcessStartInfo("arp", "-a");
            cmdProcess.OutputDataReceived += ParseArp;
            cmdProcess.EnableRaisingEvents = true;
            cmdProcess.Start();
            cmdProcess.BeginOutputReadLine();
            cmdProcess.WaitForExit();

            return _tracertArp;
        }

        private ProcessStartInfo CreateProcessStartInfo(string fileName, string arguments)
        {
            var cmdStartInfo = new ProcessStartInfo();
            //_cmdStartInfo.FileName = @"C:\Windows\System32\cmd.exe";
            cmdStartInfo.FileName = fileName;
            cmdStartInfo.Arguments = arguments;
            cmdStartInfo.RedirectStandardOutput = true;
            cmdStartInfo.RedirectStandardError = true;
            cmdStartInfo.RedirectStandardInput = true;
            cmdStartInfo.UseShellExecute = false;
            cmdStartInfo.CreateNoWindow = true;

            return cmdStartInfo;
        }

        private void ParseTracert(object sender, DataReceivedEventArgs e)
        {
            if (_tracertInteration > 3 && !string.IsNullOrEmpty(e.Data))
            {
                var tracertString = e.Data
                    .Replace("[", "")
                    .Replace("]", "")
                    .Split(" ")
                    .LastOrDefault(i => i != "");

                if (!string.IsNullOrEmpty(tracertString) && IPAddress.TryParse(tracertString, out var address))
                {
                    _tracertTable.Add(address.ToString());
                }
            }

            _tracertInteration++;
        }

        private void ParseArp(object sender, DataReceivedEventArgs e)
        {
            if (_arpInteration > 2 && !string.IsNullOrEmpty(e.Data))
            {
                var arpString = e.Data
                    .Split(" ")
                    .Where(i => !string.IsNullOrEmpty(i))
                    .ToList();

                if (arpString.Any() && arpString.Count() == 3
                                    && IPAddress.TryParse(arpString.FirstOrDefault(), out var address)
                                    && arpString.LastOrDefault() == "dynamic")
                {
                    _tracertArp.Add($"{arpString[0]} {arpString[1]}");
                }
            }

            _arpInteration++;
        }
    }
}

/// <summary> Работа с утилитами командной строки Windows. </summary>
