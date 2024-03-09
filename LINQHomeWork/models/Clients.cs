using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQHomeWork.models;

public record Clients(int Code, int Year, int Month, int Duration)
{
    public override string ToString()
    {
        return $"Client Code: {Code}, Year: {Year}, Month {Month}, Duration of classes in hours {Duration} ";
    }
    // Добавить только при работе со сложными объектами
    public virtual bool Equals(Clients? client)
    {
        return (Code == client.Code) && (Year == client.Year) && (Month == client.Month) && (Duration == client.Duration);
    }
    // Показать пример, если не добавить эту перегрузку
    public override int GetHashCode() => HashCode.Combine(Code, Year, Month, Duration);
};