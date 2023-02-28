using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class METSpawning : MonoBehaviour
{
    GameObject ship;

    public GameObject BigMET;
    public GameObject MedMET;
    public GameObject SmallMET;

    public int randomizerSpawn;
    public int randomizerMET;
    public GameObject chosenSpawn;
    GameObject chosenMET;
    int Chosen;
    public GameObject Spawn00;
    public GameObject Spawn01;
    public GameObject Spawn02;
    public GameObject Spawn03;
    public GameObject Spawn04;
    public GameObject Spawn05;
    public GameObject Spawn06;
    public GameObject Spawn07;

    public float savedCooldown;
    public float Cooldown;
    public float StartCooldown;

    public bool Chose = false;

    bool time = true;
    public float timer;
    public float eachDuration;
    public float Duration;
    public float timeLimit;

    // Start is called before the first frame update
    void Start()
    {
        Spawn00 = GameObject.Find("spawn1");
        Spawn01 = GameObject.Find("spawn2");
        Spawn02 = GameObject.Find("spawn3");
        Spawn03 = GameObject.Find("spawn4");
        Spawn04 = GameObject.Find("spawn5");
        Spawn05 = GameObject.Find("spawn6");
        Spawn06 = GameObject.Find("spawn7");
        Spawn07 = GameObject.Find("spawn8");
        ship = GameObject.Find("spaceship");
        StartCooldown = 4;
        savedCooldown = StartCooldown;
        eachDuration = Duration;
        
    }

    // Update is called once per frame
    void Update()
    {
        timer = Time.timeSinceLevelLoad;
        if (timer > eachDuration && time == true)
        {
            savedCooldown -= 0.5f;
            eachDuration += Duration;
        }
        if(savedCooldown <= timeLimit)
        {
            time = false;
            timer = 0;
        }


        if(StartCooldown > 0)
        {
            StartCooldown -= Time.deltaTime;
        }
        if(StartCooldown < 0 && !Chose)
        {
            FirstChooseSpawn();
            Chose = true;
        }

        if(Cooldown > 0)
        {
            Cooldown -= Time.deltaTime;
        }
        else
        {
            ChooseSpawn();
            Cooldown = savedCooldown;
        }
    }

    void FirstChooseSpawn()
    {
        randomizerSpawn = Random.Range(1, 101);
        if (randomizerSpawn <= 14) { chosenSpawn = Spawn00; Chosen = 0; }
        if (randomizerSpawn >= 15 && randomizerSpawn <= 28) { chosenSpawn = Spawn01; Chosen = 1; }
        if (randomizerSpawn >= 29 && randomizerSpawn <= 42) { chosenSpawn = Spawn02; Chosen = 2; }
        if (randomizerSpawn >= 43 && randomizerSpawn <= 56) {chosenSpawn = Spawn03; Chosen = 3; }
        if (randomizerSpawn >= 57 && randomizerSpawn <= 58) {chosenSpawn = Spawn04; Chosen = 4; }
        if (randomizerSpawn >= 59 && randomizerSpawn <= 72) {chosenSpawn = Spawn05; Chosen = 5; }
        if (randomizerSpawn >= 73 && randomizerSpawn <= 86) {chosenSpawn = Spawn06; Chosen = 6; }
        if (randomizerSpawn >= 87 && randomizerSpawn <= 100) {chosenSpawn = Spawn07; Chosen = 7; }
        Spawning();
    }

    void ChooseSpawn()
    {
        randomizerSpawn = Random.Range(1, 101);
        if (randomizerSpawn <= 14) {Chosen += 0; }
        if (randomizerSpawn >= 15 && randomizerSpawn <= 28) {Chosen += 1; }
        if (randomizerSpawn >= 29 && randomizerSpawn <= 42) {Chosen += 2; }
        if (randomizerSpawn >= 43 && randomizerSpawn <= 56) {Chosen += 3; }
        if (randomizerSpawn >= 57 && randomizerSpawn <= 58) {Chosen += 4; }
        if (randomizerSpawn >= 59 && randomizerSpawn <= 72) {Chosen += 5; }
        if (randomizerSpawn >= 73 && randomizerSpawn <= 86) {Chosen += 6; }
        if (randomizerSpawn >= 87 && randomizerSpawn <= 100) {Chosen += 7; }

        if(Chosen > 7)
        {
            Chosen -= 8;
        }

        chosenSpawn = Chosen == 0 ? Spawn00
            : Chosen == 1 ? Spawn01
            : Chosen == 2 ? Spawn02
            : Chosen == 3 ? Spawn03
            : Chosen == 4 ? Spawn04
            : Chosen == 5 ? Spawn05
            : Chosen == 6 ? Spawn06
            : Spawn07;

        Spawning();
    }

    void Spawning()
    {
        randomizerMET = Random.Range(1, 4);
        if (randomizerMET == 1) chosenMET = BigMET;
        else if (randomizerMET == 2) chosenMET = MedMET;
        else if (randomizerMET == 3) chosenMET = SmallMET;

        Instantiate(chosenMET, chosenSpawn.transform.position, Quaternion.identity);
    }
}
