using System;
// using System.Collections;
using System.Collections.Generic;
// using System.Security.Cryptography;
using UnityEngine; //

public class Basics : MonoBehaviour // Класс MonoBehaviour - основной класс в юнити, и любой C# скрипт будет наследовать от этого класса.
{
// Переменные
    // private int _num = 5; Если мы создаем поле private, то ниче не поменяется, работаем как в обычном C#. 
    public int _num = 5; // !!!!!! Если мы создали поле public, то у нас появляется возмонжость менять его значение через объект, на который наложен скрипт в самом интерфейсе unity.
    // Изменять значение переменной в интерфесе нужно до запуска игры, иначе оно просто не сохранятся и не учтется
    public string word; // Поле в интерфейсе unity также появится, но пустое.
    public string _name = "Nikolay";
    [NonSerialized] public int hate = 16; // [NonSerialized] из System нужно для того, чтобы поле было public, но при этом НЕ видно в интерфейсе unity
    [SerializeField] private int age; // [SerializeField] из System нужно для того, чтобы поле было private, но при этом видно в интерфейсе unity


// Массивы
    public int[] nums = new int[3]; // модификаторы [NonSerialized] и [SerializeField] также будут тут работать
    public List<string> words = new List<string>() {}; // Задание динамического массива


    void Start() // Все, что будет прописано тут, будет выводиться в юнити интерфейс нашей игрушки, будь то консоль или уже экран
    {
        // Чтобы обратиться к консоли самого unity, нужно использовать не Console.write(), а Debug.log()

        Debug.Log("Привет! Это мой первый проект!\nGame Started.");
        Debug.Log($"Ваше число: {_num}, {word}, {_name}, [NonSerialized] {hate}"); // Функции и прочее работают точно так же, как в стандартном C#
        
        /* Чтобы мой скрипт выполнился, нужно сделать так, чтобы он находился на каком-то объекте, который будет создаваться при старте игры, например: Main Camera
        Если объект, на какотором закреплен этот скрипт не создан, то и скрипт не сработает */

        if (nums.Length == 3) {
            Debug.Log("Длина равна 3");
        }
        print("Реализация метода"); // Применеие созданного нами метода в 40 строке
    }

    void pirnt(string word) {
        Debug.Log(word);
    }
}