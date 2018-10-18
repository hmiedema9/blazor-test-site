using HaydenWebsite.Server.DataAccess;
using HaydenWebsite.Shared.Models;  
using Microsoft.EntityFrameworkCore;  
using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Threading.Tasks;  
  
namespace HaydenWebsite.Server.DataAccess
{
    public class LanguageDataAccessLayer
    {
        LanguageContext db = new LanguageContext();

        //To Get all Languages details   
        public IEnumerable<ProgrammingLanguage> GetAllLanguages()
        {
            try
            {
                return db.tblLanguage.ToList();
            }
            catch
            {
                throw;
            }
        }

        //To Add new Language record     
        public void AddLanguage(ProgrammingLanguage Language)
        {
            try
            {
                db.tblLanguage.Add(Language);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //To Update the records of a particluar Language    
        public void UpdateLanguage(ProgrammingLanguage Language)
        {
            try
            {
                db.Entry(Language).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //Get the details of a particular Language    
        public ProgrammingLanguage GetLanguageData(int id)
        {
            try
            {
                ProgrammingLanguage Language = db.tblLanguage.Find(id);
                return Language;
            }
            catch
            {
                throw;
            }
        }

        //To Delete the record of a particular Language    
        public void DeleteLanguage(int id)
        {
            try
            {
                ProgrammingLanguage lang = db.tblLanguage.Find(id);
                db.tblLanguage.Remove(lang);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}