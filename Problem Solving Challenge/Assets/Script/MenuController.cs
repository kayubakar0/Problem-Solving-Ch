using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MenuController : MonoBehaviour
{
    [SerializeField] private Button Problem1;
    [SerializeField] private Button Problem2;
    [SerializeField] private Button Problem3;
    [SerializeField] private Button Problem4;
    [SerializeField] private Button Problem5;
    [SerializeField] private Button Problem6;
    [SerializeField] private Button Problem7;
    [SerializeField] private Button Problem8;
    [SerializeField] private Button Problem9;

    private void Start()
    {
        Problem1.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(1);
        });

        Problem2.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(2);
        });

        Problem3.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(3);
        });

        Problem4.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(4);
        });

        Problem5.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(5);
        });

        Problem6.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(6);
        });

        Problem7.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(7);
        });

        Problem8.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(8);
        });

        Problem9.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(9);
        });
    }
}
