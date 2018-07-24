using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReactJsCRUD.Models
{
    public class EmployeeDataAccess
    {
        EmployeeDbContext db = new EmployeeDbContext();
        //To get all employee
        public IEnumerable<TblEmployee> GetAllEmployee()
        {
            try
            {
                return db.TblEmployee.ToList();
            }
            catch
            {
                throw;
            }
        }
        //Get the details of a particular employee
        public TblEmployee GetEmployeeData(int id)
        {
            try
            {
                TblEmployee emp = db.TblEmployee.Find(id);
                return emp;
            }
            catch
            {
                throw;
            }
        }
        //To Add new employee record
        public int AddEmployee(TblEmployee emp)
        {
            try
            {
                db.TblEmployee.Add(emp);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }
        //To Update the records of a particluar employee    
        public int UpdateEmployee(TblEmployee employee)
        {
            try
            {
                db.Entry(employee).State = EntityState.Modified;
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }
        //To Delete the record of a particular employee    
        public int DeleteEmployee(int id)
        {
            try
            {
                TblEmployee emp = db.TblEmployee.Find(id);
                db.TblEmployee.Remove(emp);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }
        //To Get the list of Cities    
        public List<TblCities> GetCities()
        {
            List<TblCities> lstCity = new List<TblCities>();
            lstCity = (from CityList in db.TblCities select CityList).ToList();
            return lstCity;
        }
    }
}
