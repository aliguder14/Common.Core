// See https://aka.ms/new-console-template for more information

using Common.Core;

long minimumTCKN = GenerationIslemleri.GetMinimumValidTCKN();
long maksimumTCKN = GenerationIslemleri.GetMaximumValidTCKN();

Console.WriteLine($"Minimum TCKN: {minimumTCKN}");
Console.WriteLine($"Maksinmum TCKN: {maksimumTCKN}");
