using Database;
using Database.Entities;
using MVVM.Tools;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Viemodel
{
    public class RecipeViewModel: ObservableObject
    {
        private readonly MyDbContext db;

        public RecipeViewModel(MyDbContext db)
        {
            this.db = db;
            Recipes = db.Recipes.AsObservableCollection();
        }

        //Properties
        private ObservableCollection<Recipe> recipes;
        private string name = "";
        private string costprice = "";
        private string amount = "";
        private string unit = "";

        public ObservableCollection<Recipe> Recipes
        {
            get => recipes; 
            set 
            {
                recipes = value;
                RaisePropertyChangedEvent(nameof(Recipes));
            }
        }

        public string NameTxtBox
        {
            get => name;
            set
            {
                name = value;
                RaisePropertyChangedEvent(nameof(NameTxtBox));
            }
        }
        public string CostpriceTxtBox
        {
            get => costprice;
            set
            {
                costprice = value;
                RaisePropertyChangedEvent(nameof(CostpriceTxtBox));
            }
        }
        public string AmountTxtBox
        {
            get => amount;
            set
            {
                amount = value;
                RaisePropertyChangedEvent(nameof(AmountTxtBox));
            }
        }

        public string UnitTxtBox
        {
            get => unit;
            set
            {
                unit = value;
                RaisePropertyChangedEvent(nameof(UnitTxtBox));
            }
        }
        private Recipe selectedRecipe;

        public Recipe SelectedRecipe
        {
            get => selectedRecipe;
            set 
            {
                selectedRecipe = value;
                RecipeResources = db.RecipeDetails.Where(x => x.RecipeId == SelectedRecipe.Id).Select(x => x.Resource).AsObservableCollection();
                RaisePropertyChangedEvent(nameof(SelectedRecipe));
            }
        }
        private ObservableCollection<Resource> recipeResources;

        public ObservableCollection<Resource> RecipeResources
        {
            get => recipeResources;
            set
            {
                recipeResources = value;
                RaisePropertyChangedEvent(nameof(RecipeResources));
            }
        }



        /*Commands*/
        public ICommand AddRecipeCommand => new RelayCommand<string>(
            AddRecipe,
            x => NameTxtBox.Trim().Length > 0
            );

        /*/Helper*/
        private void AddRecipe(string obj)
        {
            var recipe = new Recipe
            {
                Name = NameTxtBox,
                Amount = int.Parse(AmountTxtBox),
                Costprice = double.Parse(CostpriceTxtBox),
                Unit = UnitTxtBox,
            };
            db.Recipes.Add(recipe);
            db.SaveChanges();
            Recipes = db.Recipes.AsObservableCollection();
        }
    }
}
