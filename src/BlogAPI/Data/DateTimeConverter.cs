using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlogAPI.Data;

public class DateTimeConverter : ValueConverter<DateTime, DateTime>
{
    public DateTimeConverter() : base(dt => dt.ToUniversalTime(), dt => dt) { }
}