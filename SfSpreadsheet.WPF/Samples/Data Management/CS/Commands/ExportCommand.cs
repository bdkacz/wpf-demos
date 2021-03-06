﻿using System.Windows.Input;
using Syncfusion.XlsIO;
using System.Data;
using ImportDataTable.View;
using Syncfusion.UI.Xaml.Spreadsheet;

namespace ImportDataTable.Commands
{
    public static class ExportCommand
    {
        static ExportCommand()
        {
            CommandManager.RegisterClassCommandBinding(typeof(SfSpreadsheet), new CommandBinding(ExportToDataTable, OnExecuteExportToDataTable, OnCanExecuteExportToDataTable));
        }

        public static RoutedCommand ExportToDataTable = new RoutedCommand("ExportToDataTable", typeof(SfSpreadsheet));

        private static void OnExecuteExportToDataTable(object sender, ExecutedRoutedEventArgs args)
        {
            SfSpreadsheet Spreadsheet = args.Source as SfSpreadsheet;
            if (Spreadsheet != null)
            {
                IWorksheet sheet = Spreadsheet.Workbook.Worksheets[0];
                IRange range = sheet.Range["A1:K50"];
                DataTable Dt = sheet.ExportDataTable(range, ExcelExportDataTableOptions.ColumnNames);
                DataGridView dgv = new DataGridView();
                dgv.DataContext = Dt;
                dgv.ShowDialog();
            }
        }

        private static void OnCanExecuteExportToDataTable(object sender, CanExecuteRoutedEventArgs args)
        {
            args.CanExecute = true;
        }
    }
}
