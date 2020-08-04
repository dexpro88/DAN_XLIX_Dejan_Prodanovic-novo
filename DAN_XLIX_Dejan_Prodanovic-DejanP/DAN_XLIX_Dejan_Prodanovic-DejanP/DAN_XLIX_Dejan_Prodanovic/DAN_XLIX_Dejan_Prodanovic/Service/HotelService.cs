﻿using DAN_XLIX_Dejan_Prodanovic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAN_XLIX_Dejan_Prodanovic.Service
{
    class HotelService:IHotelService
    {
        public tblUser AddUser(tblUser user)
        {
            try
            {
                using (HotelDataBaseEntities context = new HotelDataBaseEntities())
                {

                    tblUser newUser = new tblUser();
                    newUser.FullName = user.FullName;
                    newUser.DateOfBirth = user.DateOfBirth;
                    newUser.Mail = user.Mail;
                    newUser.Username = user.Username;
                    newUser.Passwd = user.Passwd;


                    context.tblUsers.Add(newUser);
                    context.SaveChanges();
                    return newUser;

                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception" + ex.Message.ToString());
                return null;
            }
        }

        public tblManager AddManager(tblManager manager)
        {
            try
            {
                using (HotelDataBaseEntities context = new HotelDataBaseEntities())
                {

                    tblManager newManager = new tblManager();
                    newManager.HotelFloor = manager.HotelFloor;
                    newManager.Experience = manager.Experience;
                    newManager.QualificationsLevel = manager.QualificationsLevel;
                    newManager.UserId = manager.UserId;
                   

                    context.tblManagers.Add(newManager);
                    context.SaveChanges();

                    return newManager;

                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception" + ex.Message.ToString());
                return null;
            }
        }

        public tblEmployee AddEmployee(tblEmployee employee)
        {
            try
            {
                using (HotelDataBaseEntities context = new HotelDataBaseEntities())
                {

                    tblEmployee newEmployee = new tblEmployee();
                    newEmployee.HotelFloor = employee.HotelFloor;
                    newEmployee.Citizenship = employee.Citizenship;
                    newEmployee.Engagement = employee.Engagement;
                    newEmployee.Gender = employee.Gender;
                    newEmployee.Salary = employee.Salary;
                    newEmployee.UserId = employee.UserId;

                    context.tblEmployees.Add(newEmployee);
                    context.SaveChanges();

                    return newEmployee;

                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception" + ex.Message.ToString());
                return null;
            }
        }


        public tblUser GetGetEployeeByUserNameAndPass(string userName, string password)
        {
            try
            {
                using (HotelDataBaseEntities context = new HotelDataBaseEntities())
                {


                    tblUser user = (from x in context.tblUsers
                                          where x.Username == userName &&
                                          x.Passwd == password
                                        select x).First();

                    return user;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception" + ex.Message.ToString());
                return null;
            }
        }

        public tblEmployee GetEmloyeByUserId(int UserId)
        {
            try
            {
                using (HotelDataBaseEntities context = new HotelDataBaseEntities())
                {


                    tblEmployee user = (from x in context.tblEmployees
                                    where x.UserId == UserId  
                                    select x).First();

                    return user;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception" + ex.Message.ToString());
                return null;
            }
        }

        public List<tblUser> GetUsers()
        {
            try
            {
                using (HotelDataBaseEntities context = new HotelDataBaseEntities())
                {
                    List<tblUser> list = new List<tblUser>();
                    list = (from x in context.tblUsers select x).ToList();

                    return list;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception" + ex.Message.ToString());
                return null;
            }
        }

    }
}
