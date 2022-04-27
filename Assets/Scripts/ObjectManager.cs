using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    [SerializeField] private GameObject animalObject;
    [SerializeField] private GameObject catObject;
    [SerializeField] private GameObject dogObject;

    void Start()
    {
        Animal animal = animalObject.GetComponent<Animal>();
        animal.GivenName = DataPersistence.Instance.animalName;
        animal.gameObject.SetActive(true);

        Cat cat = catObject.GetComponent<Cat>();
        cat.GivenName = DataPersistence.Instance.catName;
        cat.gameObject.SetActive(true);

        Dog dog = dogObject.GetComponent<Dog>();
        dog.GivenName = DataPersistence.Instance.dogName;
        dog.gameObject.SetActive(true);
    }
}
