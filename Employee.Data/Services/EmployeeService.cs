namespace Employee.Data.Services
{
    using System.Collections.Generic;
    using Entities;
    using MongoDB.Driver.Builders;

    public class EmployeeService: EntityService<Employee>
    {
        public IEnumerable<Employee> GetEmployeesDetails(int limit, int skip)
        {
            var gamesCursor = this.MongoConnectionHandler.MongoCollection.FindAllAs<Employee>()
                .SetSortOrder(SortBy<Employee>.Descending(e => e.Name))
                .SetLimit(limit)
                .SetSkip(skip)
                .SetFields(Fields<Employee>.Include(e => e.Id, e => e.Name));
            return gamesCursor;
        }


        public override void Update(Employee entity)
        {
            //// Not necessary for the example
        }
    }
}
