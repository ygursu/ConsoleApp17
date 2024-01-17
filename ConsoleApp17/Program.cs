private void btnCalculate_Click(object sender, EventArgs e)
{
    DateTime startDate = dateTimePickerStartDate.Value;
    DateTime endDate = dateTimePickerEndDate.Value;

    int years = endDate.Year - startDate.Year;
    int months = endDate.Month - startDate.Month;
    int days = endDate.Day - startDate.Day;

    if (days < 0)
    {
        months--;
        days += DateTime.DaysInMonth(startDate.Year, startDate.Month);
    }

    if (months < 0)
    {
        years--;
        months += 12;
    }

    MessageBox.Show(String.Format("Fark: {0} yıl, {1} ay, {2} gün", years, months, days));
}

