  using System;
  using System.Collections;
  using System.Collections.Generic;
  using System.Windows;
  using CalendarCore.Enums;
  using CalendarCore.Models;
  
  namespace CalendarDemo.Basic
  {
      public partial class MainWindow : Window
      {
          private int Year;
          private int Month;
  
          public MainWindow()
          {
              InitializeComponent();
  
              Year = DateTime.Now.Year;
              Month = DateTime.Now.Month;
  
              Loaded += (s,e)=> Refresh(CalendarMove.None);
              btnPreview.Click += (ps, pe) => Refresh(CalendarMove.Preview);
              btnNext.Click += (ns, ne) => Refresh(CalendarMove.Next);
          }
  
          private void Refresh(CalendarMove move)
          {
              DateTime currentDateTime = new DateTime(Year, Month, 1);
              int moveMonth = 0;
              switch (move)
              {
                  case CalendarMove.None: moveMonth = 0; break;
                  case CalendarMove.Preview: moveMonth = -1; break;
                  case CalendarMove.Next: moveMonth = 1; break;
              }
  
              Year = currentDateTime.AddMonths(moveMonth).Year; 
              Month = currentDateTime.AddMonths(moveMonth).Month;
  
              calendar.ItemsSource = GenerateCalendar(Year, Month);
          }
  
          private IEnumerable GenerateCalendar(int year, int month)
          {
              List<DayModel> days = new List<DayModel>();
  
              // Step 1. Add days of last month.
              AddDaysOfLastMonth(year, month, ref days);
  
              // Step 2. Add days of current mon.th
              AddDaysOfCurrentMonth(year, month, ref days);
  
              // Step 3. Add days of next month.
              AddDaysOfNextMonth(year, month, ref days);
              return days;
          }
  
          private void AddDaysOfLastMonth(int year, int month, ref List<DayModel> days)
          {
              var lastMonth = new DateTime(year, month, 1).AddMonths(-1);
  
              int dayStarting;
              int lastDayOfLastMonth = DateTime.DaysInMonth(lastMonth.Year, lastMonth.Month);
              DayOfWeek firstDayOfWeek = new DateTime(year, month, 1).DayOfWeek;
  
              switch (firstDayOfWeek)
              {
                  case DayOfWeek.Monday: dayStarting = 0; break;
                  case DayOfWeek.Tuesday: dayStarting = 1; break;
                  case DayOfWeek.Wednesday: dayStarting = 2; break;
                  case DayOfWeek.Thursday: dayStarting = 3; break;
                  case DayOfWeek.Friday: dayStarting = 4; break;
                  case DayOfWeek.Saturday: dayStarting = 5; break;
                  case DayOfWeek.Sunday: dayStarting = 6; break;
                  default: dayStarting = 0;break;
              }
  
              for (int i = 1; i <= dayStarting; i++)
              {
                  days.Add(new DayModel
                  {
                      Date = new DateTime(lastMonth.Year, lastMonth.Month, lastDayOfLastMonth + i - dayStarting),
                      IsLastMonth = true
                  });
              }
          }
  
          private void AddDaysOfCurrentMonth(int year, int month, ref List<DayModel> days)
          {
              int lastDay = DateTime.DaysInMonth(year, month);
              for (int i = 1; i <= lastDay; i++)
              {
                  days.Add(new DayModel { Date = new DateTime(year, month, i) });
              }
          }
  
          private void AddDaysOfNextMonth(int year, int month, ref List<DayModel> days)
          {
              var nextMonth = new DateTime(year, month, 1).AddMonths(1);
              var lastDayofCurrentMonth = DateTime.DaysInMonth(year, month);
  
              int dayStarting;
              DayOfWeek lastDayOfWeek = new DateTime(year, month, lastDayofCurrentMonth).DayOfWeek;
  
              switch (lastDayOfWeek)
              {
                  case DayOfWeek.Monday: dayStarting = 6; break;
                  case DayOfWeek.Tuesday: dayStarting = 5; break;
                  case DayOfWeek.Wednesday: dayStarting = 4; break;
                  case DayOfWeek.Thursday: dayStarting = 3; break;
                  case DayOfWeek.Friday: dayStarting = 2; break;
                  case DayOfWeek.Saturday: dayStarting = 1; break;
                  case DayOfWeek.Sunday: dayStarting = 0; break;
                  default: dayStarting = 0; break;
              }
  
              for (int i = 1; i <= dayStarting; i++)
              {
                  days.Add(new DayModel
                  {
                      Date = new DateTime(nextMonth.Year, nextMonth.Month, i),
                      IsNextMonth = true
                  });
              }
          }
      }
  }
