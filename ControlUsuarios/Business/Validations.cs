﻿using System;
using System.Collections.Generic;
using System.Data;
using Connections;
using Options;
using Entity;
using System.Text.RegularExpressions;

namespace Business
{
    public class Validations
    {
        private Queries ObjQueries = new Queries();
        private List<object> ValueForms = new List<object>();

        private void CatchExceptions(Exception Error, TypeModules Modulo)
        {
            ValueForms.Clear();
            ValueForms.Add(Error.InnerException); //Tipo de Error
            ValueForms.Add(Error.Message); //Mensaje de la excepción
            ValueForms.Add(Error.Source); //Origen del error
            ValueForms.Add(Error.TargetSite); //Método que generó la excepción
            ValueForms.Add(DateTime.Now.ToShortDateString()); //Fecha
            ValueForms.Add(DateTime.Now.ToLongTimeString()); //Hora
            ObjQueries.ConsultaCUD("Errors", ValueForms);
        } //Clave de Método: Validations-CE

        public DataTable LogSession(TypeModules Modulo, string NumControl, string Password)
        {
            ValueForms.Clear();
            try
            {
                if (NumControl.Length.Equals(8))
                {
                    if (string.IsNullOrEmpty(NumControl) || ReferenceEquals(1, int.Parse(NumControl)) || string.IsNullOrEmpty(Password))
                        throw new Exception();
                }
                else
                {
                    if (string.IsNullOrEmpty(NumControl) || ReferenceEquals(1, int.Parse(NumControl.Substring(1, (NumControl.Length - 1)))))
                        throw new Exception();
                }
                ValueForms.Add(NumControl); ValueForms.Add(Password);
                return ObjQueries.ConsultaLeerRegistros(nameof(LogSession), ValueForms);
            }
            catch (Exception Error)
            {
                CatchExceptions(Error, Modulo);
                return null;
            }
            finally
            {
                ValueForms.Clear();
            }
        } //Clave de Método: Validations-LG

        public DataTable GridSearchMethod(TypeModules Modulo, TypeSearch Option)
        {
            ValueForms.Clear();
            try
            {
                string StoredProcedure = "";
                if (Option.Equals(0))
                    throw new Exception();
                switch (Option)
                {
                    case TypeSearch.Users:
                        {
                            StoredProcedure = "LoadUsers";
                            break;
                        }
                    case TypeSearch.Admin:
                        {
                            StoredProcedure = "LoadAdmins";
                            break;
                        }
                    case TypeSearch.Moves:
                        {
                            StoredProcedure = "LoadMoves";
                            break;
                        }
                    case TypeSearch.Areas:

                        {
                            StoredProcedure = "LoadAreas";
                            break;
                        }
                    default:
                        throw new Exception();
                }
                return ObjQueries.ConsultaLeerRegistros(StoredProcedure, ValueForms);
            }catch(Exception Error)
            {
                CatchExceptions(Error, Modulo);
                return null;
            }
            finally
            {
                ValueForms.Clear();
            }
        } //Clave de Método: Validations-GSM

        public DataTable ExistUsuario(TypeModules Modulo, string NumControl)
        {
            ValueForms.Clear();
            try
            {
                if (string.IsNullOrEmpty(NumControl) || ReferenceEquals(1, int.Parse(NumControl)))
                    throw new Exception();
                ValueForms.Add(NumControl);
                return ObjQueries.ConsultaLeerRegistros("ExistUser", ValueForms);
            }
            catch(Exception Error)
            {
                CatchExceptions(Error, Modulo);
                return null;
            }
            finally
            {
                ValueForms.Clear();
            }
        } //Clave de Método: Validations-EU

        public void UpdateUser(TypeModules Modulo, ModifyUsers ObjModifyUser)
        {
            ValueForms.Clear();
            try
            {
                ValueForms.Add(ObjModifyUser.NumControl);
                ValueForms.Add((ObjModifyUser.FirstName.Trim() + " " + ObjModifyUser.SecondName).Trim());
                ValueForms.Add(ObjModifyUser.FirstLastName);
                ValueForms.Add(ObjModifyUser.SecondLastName);
                ValueForms.Add(ObjModifyUser.Sex);
                ValueForms.Add(ObjModifyUser.IndexDeparment);
                ValueForms.Add(ObjModifyUser.Status);
                ObjQueries.ConsultaCUD("UpdateUser", ValueForms);
            }
            catch(Exception Error)
            {
                CatchExceptions(Error, Modulo);
            }
            finally
            {
                ValueForms.Clear();
            }
        } //Clave de Método: Validations-UU

        public DataTable SearchUser(TypeModules Modulo, byte IndexSearch, string InputText, char Sex, byte IndexArea, char Status)
        {
            sbyte i = 0;
            ValueForms.Clear();
            try
            {
                ValueForms.Add(IndexSearch);
                if (IndexSearch > 0)
                {
                    InputText = OnlyWordsMethod(InputText);
                }
                if (InputText.Trim().Split(' ').Length > 1)
                {
                    ValueForms.Add(InputText);
                    ValueForms.Add(InputText);
                    ValueForms.Add(InputText.Split(' ')[0]);
                    ValueForms.Add(InputText.Split(' ')[1]);
                    ValueForms.Add(Sex);
                    ValueForms.Add(IndexArea);
                    ValueForms.Add(Status);
                }
                else
                {
                    while (i++ < 4) ValueForms.Add(InputText);
                    ValueForms.Add(Sex);
                    ValueForms.Add(IndexArea);
                    ValueForms.Add(Status);
                }
                return ObjQueries.ConsultaLeerRegistros("SearchUsers", ValueForms);
            }
            catch (Exception Error)
            {
                CatchExceptions(Error, Modulo);
                return null;
            }
            finally
            {
                ValueForms.Clear();
                i = 0;
            }
        } //Clave de Método: Validations-SU

        public void SearchMoves(TypeModules Modulo, Search ObjSearch)
        {
            ValueForms.Clear();
            try
            {
                ValueForms.Add(ObjSearch.NumControl);
                ValueForms.Add(ObjSearch.IndexDeparmentStart);
                ValueForms.Add(ObjSearch.IndexDeparmentEnd);
                ValueForms.Add(ObjSearch.SexStart);
                ValueForms.Add(ObjSearch.SexEnd);
                ValueForms.Add(ObjSearch.DateStart.ToShortDateString());
                ValueForms.Add(ObjSearch.DateEnd.ToShortDateString());
                ObjSearch.Table = ObjQueries.ConsultaLeerRegistros("SearchMoves", ValueForms);
            }
            catch(Exception Error)
            {
                CatchExceptions(Error, Modulo);
            }
            finally
            {
                ValueForms.Clear();
            }
        } //Clave de Método: Validations-SM

        public Result AddUser(TypeModules Modulo, ModifyUsers ObjModifyUser)
        {
            ValueForms.Clear();
            try
            {
                if(ExistUsuario(Modulo, ObjModifyUser.NumControl).Rows.Count > 0) throw new DuplicateNameException();
                if (!NumControlCheck(ObjModifyUser.NumControl)) throw new InvalidCastException();
                if (string.IsNullOrEmpty(ObjModifyUser.FirstName) && string.IsNullOrEmpty(ObjModifyUser.SecondName)) throw new NullReferenceException();
                if (string.IsNullOrEmpty(ObjModifyUser.FirstLastName) && string.IsNullOrEmpty(ObjModifyUser.SecondLastName)) throw new FormatException();
                ValueForms.Add(ObjModifyUser.NumControl);
                ValueForms.Add(OnlyWordsMethod(ObjModifyUser.SecondName != string.Empty ? ObjModifyUser.FirstName + " " + ObjModifyUser.SecondName : ObjModifyUser.FirstName));
                ValueForms.Add(OnlyWordsMethod(ObjModifyUser.FirstLastName));
                ValueForms.Add(OnlyWordsMethod(ObjModifyUser.SecondLastName));
                ValueForms.Add(ObjModifyUser.Sex);
                ValueForms.Add(ObjModifyUser.IndexDeparment);
                ValueForms.Add(ObjModifyUser.Status);
                ObjQueries.ConsultaCUD("AddUser", ValueForms);
                return Result.Correct;
            }
            catch(DuplicateNameException)
            {
                return Result.Duplicate;
            }
            catch (InvalidCastException)
            {
                return Result.Invalid;
            }
            catch (NullReferenceException)
            {
                return Result.NullNames;
            }
            catch (FormatException)
            {
                return Result.NullLastNames;
            }
            catch(Exception Error)
            {
                CatchExceptions(Error, Modulo);
                return Result.Incorrect;
            }
            finally
            {
                ValueForms.Clear();
            }
        } //Clave de Método: Validations-AU

        public void SearchStats(TypeModules Modulo, Search ObjSearch)
        {
            ValueForms.Clear();
            try
            {
                ValueForms.Add(ObjSearch.SexStart);
                ValueForms.Add(ObjSearch.SexEnd);
                for (int i = 0; i < ObjSearch.Services.Count; i++) ValueForms.Add(ObjSearch.Services[i]);
                ValueForms.Add(ObjSearch.DateStart.ToShortDateString());
                ValueForms.Add(ObjSearch.DateEnd.ToShortDateString());
                ValueForms.Add(ObjSearch.IndexDeparmentStart);
                ValueForms.Add(ObjSearch.IndexDeparmentEnd);
                ObjSearch.Table = ObjQueries.ConsultaLeerRegistros("SearchStats", ValueForms);
            }
            catch (Exception Error)
            {
                CatchExceptions(Error, Modulo);
            }
            finally
            {
                ValueForms.Clear();
            }
        } //Clave de Método: Validations-NS

        public string OnlyWordsMethod(string str)
        {
            if (Regex.IsMatch(str, "[ÁÉÍÓÚ]+"))
            {
                foreach (char item in str)
                {
                    switch (item)
                    {
                        case 'Á': { str = str.Replace(item, 'A'); break; }
                        case 'É': { str = str.Replace(item, 'E'); break; }
                        case 'Í': { str = str.Replace(item, 'I'); break; }
                        case 'Ó': { str = str.Replace(item, 'O'); break; }
                        default: { break; }
                    }
                }
            }
            return Regex.Replace(Regex.Replace(str, "[^A-ZÑ ]+", ""), @"\s{2,}", " ").Trim();
        } //Clave de Método: Validations-OWM

        public string RemoveAccent(string str)
        {
            if (Regex.IsMatch(str, "[ÁÉÍÓÚ]+"))
            {
                foreach (char item in str)
                {
                    switch (item)
                    {
                        case 'Á': { str = str.Replace(item, 'A'); break; }
                        case 'É': { str = str.Replace(item, 'E'); break; }
                        case 'Í': { str = str.Replace(item, 'I'); break; }
                        case 'Ó': { str = str.Replace(item, 'O'); break; }
                        default: { break; }
                    }
                }
            }
            return str;
        }

        public string CleanLineaImport(string str) => Regex.Replace(str, @"[^A-Z0-9, ]|\s{2,}", "").Trim().ToUpper(); //Clave de Método: Validations-OWON

        public bool NumControlCheck(string str) => Regex.IsMatch(str, @"^[CB]?\d{8}$"); //Clave de Método: Validations-NCC

        public bool NamesAndLastNameCheck(string str) => Regex.IsMatch(str, @"^[A-Z]+\s[A-Z]+$"); //Clave de Método: Validations-NALNC

        //Clave de Método: Validations-PUUV
        public bool PopUpUsersValidations(ModifyUsers ObjModifyUsersSource, ModifyUsers ObjModifyUsers) => ObjModifyUsersSource.NumControl == ObjModifyUsers.NumControl && (ObjModifyUsersSource.FirstName != ObjModifyUsers.FirstName || ObjModifyUsersSource.SecondName != ObjModifyUsers.SecondName || ObjModifyUsersSource.FirstLastName != ObjModifyUsers.FirstLastName || ObjModifyUsersSource.SecondLastName != ObjModifyUsers.SecondLastName || ObjModifyUsersSource.Department != ObjModifyUsers.Department || ObjModifyUsersSource.Status != ObjModifyUsers.Status || ObjModifyUsersSource.Sex != ObjModifyUsers.Sex);
    }
}