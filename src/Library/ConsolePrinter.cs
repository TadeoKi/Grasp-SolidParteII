//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter
    {

        double TotalAll = Recipe.GetProductionCost() ;
        public static void PrintRecipe()
        {
            Console.WriteLine($"Receta de {Recipe.FinalProduct.Description}:");
            foreach (Step step in Recipe.steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }

            Console.WriteLine($"Precio Total: { Recipe.GetProductionCost() }");
        }
    }
}