﻿using Academics.DataModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using VITacademics.Managers;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


namespace VITacademics.UIControls
{
    public sealed partial class BasicTimetableControl : UserControl, IProxiedControl
    {
        public event EventHandler<RequestEventArgs> ActionRequested;

        public BasicTimetableControl()
        {
            this.InitializeComponent();
#if !DEBUG
            GoogleAnalytics.EasyTracker.GetTracker().SendView("Timetable");
#endif
        }

        private void ListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(ActionRequested != null)
            {
                ActionRequested(this, new RequestEventArgs(typeof(CourseInfoControl), (e.ClickedItem as ClassHours).Parent.ClassNumber.ToString()));
            }
        }

        public string DisplayTitle
        {
            get { return "Timetable"; }
        }

        public Dictionary<string, object> SaveState()
        {
            var state = new Dictionary<string,object>(1);
            state.Add("currentIndex", rootPivot.SelectedIndex);
            return state;
        }

        public void LoadView(string parameter, Dictionary<string, object> lastState = null)
        {
            try
            {
                Timetable timetable = UserManager.GetCurrentTimetable();
                int j = 0, todayIndex = -1;
                List<PivotItem> pivotItems = new List<PivotItem>(7);
                DayOfWeek today = DateTimeOffset.Now.DayOfWeek;
                
                for (int i = 0; i < 7; i++)
                {
                    var daySchedule = timetable[(DayOfWeek)i];
                    if (daySchedule.Count != 0)
                    {
                        pivotItems.Add(new PivotItem());
                        pivotItems[j].Header = ((DayOfWeek)i).ToString().ToLower();
                        pivotItems[j].DataContext = daySchedule;

                        if (i == (int)today)
                            todayIndex = j;
                        j++;
                    }
                }
                rootPivot.ItemsSource = pivotItems;

                // Restore last state if available.
                if (lastState != null)
                    rootPivot.SelectedIndex = (int)lastState["currentIndex"];
                else if (todayIndex > 0)
                    rootPivot.SelectedIndex = todayIndex;
            }
            catch
            {
                return;
            }
        }
    }
}
