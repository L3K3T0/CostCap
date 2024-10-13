using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompIA
{
    /*When using static attributes on static generic classes each generic class will have its own instance of the static variable
    if that static class is a unique datatype hence page manager CANNOT be a generic class*/

    // A static class which will oversee all form creation to ensure we don't have multiple form instances.
    // As well as some added form functionality if needed.

    // page manager should keep track of how many pages are open at a time and close them if it is 0.
    // typeof keyword returns the data type of a variable
    public static class PageManager 
    {
        public static List<Form> mainForms = new List<Form>(); // Aggregation - Forms is the parent class of the pages.
        private static Form currentForm; 
        private static Form burner;
        public static string Salary;
        public static bool msgBox = true;
        #region Main form and burner form behaviour
        public static Form CurrentForm // Getter for current form (encapsulation)
        {
            get { return currentForm; }
            set { value = currentForm; }
        }
        // gets the burner instance
        public static Form GetBurner(Form burnerInstance)
        {
            // here to ensure that the Form being passed is a the Burner Class
            if (burnerInstance is Burner)
            {
                burner = burnerInstance;
                return burner;
            }
            else { return null; }
            
        }
        // we use this generic method to avoid having multiple instances of the same window when loading it.
        public static void LoadMainForm<T>(T form) where T : Form //generic constraint forces T to be from the parent class
                                                                  // hence allowing me to use the functions available to forms
        {
            bool isLoaded = false;
            int index = 0;
            foreach (var item in mainForms)
            {
                if (item is T) // checks if the item is the generic data type
                {
                    isLoaded = true;
                    break;
                }
                index++;
            }
            if (isLoaded == true) // will instead load the page from the list of pages instead of making a new one
            {                    // elementAT allows us to return the element at 'index' and is an extension method
                mainForms.ElementAt(index).Show();
            }
            else 
            { // If there is no object w/ the data type in the LL then we add that page to the LinkedList
                mainForms.Add(form);
                form.Show(); //  <= as we used the generic constraint forcing it to be a Form or inherit from it
                // we are able to invoke the .form() method
            }
            CurrentForm = form; //Used mainly for breakpoints/ debugging lets me see what form is being loaded in the call stack
        }
        public static void MainFormRemove<T>(T form) where T : Form
        {
            int index = -1;
            foreach (var item in mainForms)
            {
                index++;
                if (item is T)
                {
                    mainForms.ElementAt(index).Dispose();
                    // Disposes the form and removes it from the list
                    // clearing it from the list
                    mainForms.RemoveAt(index);
                    break; // must be broken or there will be an error as the size of the list changed
                }
            }
        }
        public static void CloseApp()
        {
            burner.Close();
        }
        #endregion
    }
}