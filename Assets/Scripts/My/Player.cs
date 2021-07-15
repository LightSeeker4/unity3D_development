using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour //, ITakeDamage
{
//    [SerializeField] private GameObject _bulletPref;
//    [SerializeField] private GameObject _MinePref;
//    [SerializeField] private GameObject _GrenadePref;
//    [SerializeField] private Transform _bulletStartPosition;
//    [SerializeField] private Transform _MineStartPosition;
//    [SerializeField] private Transform _head;
//    [SerializeField] private Transform _RightArm;
    [SerializeField] private float _speed = 6;
//    [SerializeField] private float _runSpeed;
    [SerializeField] private int sensitivity;
//    [SerializeField] public int _ammoCount;
//    [SerializeField] public int _MaxHP = 100;
//    [SerializeField] private Rigidbody _RigidBodyPlayer;
//    [SerializeField] private float _PlayerJumpPower = 250f;
    [SerializeField] private float _sensivityCam;
    [SerializeField] public bool checkActions;
//    [SerializeField] private Animator _animat;
//    [SerializeField] private float _reloadTime = 0.3f;
//    [SerializeField] private GameObject _canv;
//    [SerializeField] private GameObject _canvDeath;


//    internal int _HP;
//    //private NavMeshAgent _navMeshAgent;
//    [SerializeField] private bool _ground;
    private float mouseLook;
    private Vector3 _direction;
    private Vector3 _rotation;
    private float _xRotation;
    //    private float _xRotationArm;
    //    private bool _reload = true;
    //    private bool paused = false;
    //    private AudioSource _audioSource;

    //    private void Awake()
    //    {
    //        _HP = _MaxHP;
    //        _ammoCount = 20;
    //        _animat = GetComponent<Animator>();
    //        _audioSource = GetComponent<AudioSource>();
    //    }


    void Update()
    {
        PlayerLook();
        _direction.x = Input.GetAxis("Horizontal");
        _direction.z = Input.GetAxis("Vertical");

        if (Input.anyKey.Equals(false))
        {
            checkActions = false;
        }
        else
        {
            checkActions = true;
        }

        //        if (Input.GetKeyDown(KeyCode.Mouse0) && _reload)
        //        {
        //            if (_ammoCount > 0)
        //            {
        //                _animat.SetBool("Fire", true);
        //                Fire();
        //            }
        //        }

        //        if (Input.GetKeyDown(KeyCode.Mouse1))
        //        {
        //            DropMine();
        //        }

        //        if (Input.GetKeyDown(KeyCode.G))
        //        {
        //            DropGrenade();
        //        }

        //        if (Input.GetKeyDown(KeyCode.Escape))
        //        {
        //            if (!paused)
        //            {
        //                Time.timeScale = 0;
        //                paused = true;
        //                _canv.SetActive(true);
        //                Cursor.lockState = CursorLockMode.None;
        //            }
        //            else
        //            {
        //                Time.timeScale = 1;
        //                paused = false;
        //                _canv.SetActive(false);
        //                Cursor.lockState = CursorLockMode.Locked;
        //            }
        //        }

        //        if (Input.GetKey(KeyCode.LeftShift))
        //        {
        //            _animat.SetBool("Run", true);
        //            _speed = _runSpeed;
        //        }
        //        else
        //        {
        //            _animat.SetBool("Run", false);
        //            _speed = 6;
        //        }

        //        if (Input.GetKeyDown(KeyCode.Space))
        //        {
        //            if (_ground == true)
        //            {
        //                _animat.SetBool("Jump", true);
        //            }
        //            else
        //            {
        //                _ground = false;
        //            }
        //        }
    }

    private void FixedUpdate()
    {
        var speed = _direction * _speed * Time.fixedDeltaTime;
        transform.Translate(speed);

        //        if (_direction != Vector3.zero)
        //            _animat.SetBool("Walk", true);
        //        else
        //            _animat.SetBool("Walk", false);

                _direction = Vector3.zero;
            }

        //    private void Reload()
        //    {
        //        _animat.SetBool("Fire", false);
        //        _reload = true;
        //    }
            private void PlayerLook()
            {
        _rotation.x = Input.GetAxis("Mouse X") * _sensivityCam * Time.deltaTime;
        _rotation.y = Input.GetAxis("Mouse Y") * _sensivityCam * Time.deltaTime;

        _xRotation -= _rotation.y * 6;
        _xRotation = Mathf.Clamp(_xRotation, -25f, 45f);

        //_xRotationArm -= _rotation.y * 6;
        //_xRotationArm = Mathf.Clamp(_xRotationArm, -25f, 45f);

        transform.Rotate(0f, _rotation.x, 0f);

        //        _head.localRotation = Quaternion.Euler(_xRotation, 0, 0);
        //        _RightArm.localRotation = Quaternion.Euler(_xRotationArm, 0, 0);

            }


        //    private void Jump()
        //    {

        //        _RigidBodyPlayer.AddForce(transform.up * _PlayerJumpPower);
        //        _animat.SetBool("Jump", false);

        //    }
        //    private void Fire()
        //    {
        //        var bullet = Instantiate(_bulletPref, _bulletStartPosition.position, _RightArm.transform.rotation);
        //        var b = bullet.GetComponent<Bullet>();
        //        b.Init();
        //        _audioSource.Play();
        //        _ammoCount--;
        //        _reload = false;
        //        Invoke("Reload", _reloadTime);
        //    }

        //    private void DropMine()
        //    {
        //        var Mine = Instantiate(_MinePref, _MineStartPosition.position, Quaternion.identity);
        //        var c = Mine.GetComponent<Mine>();
        //        c.Init();
        //    }

        //    private void DropGrenade()
        //    {
        //        var Grenade = Instantiate(_GrenadePref, _bulletStartPosition.position, transform.rotation);
        //        var g = Grenade.GetComponent<Grenade>();
        //        g.Init();
        //    }

        //    public void TakeAmmo(int ammoCount)
        //    {
        //        _ammoCount += ammoCount;
        //    }

        //    public void TakeMedKit(int MedKitHp)
        //    {
        //        _HP += MedKitHp;
        //        if (_HP >= 100)
        //        {
        //            _HP = 100;
        //        }
        //    }
        //    public void TakeDamage(int damage)
        //    {
        //        _HP -= damage;
        //        if (_HP <= 0)
        //        {
        //            Death();
        //        }

        //    }
        //    private void Death()
        //    {
        //        _animat.SetTrigger("Death");
        //        Invoke("Destroy", 3);

        //    }
        //    private void Destroy()
        //    {
        //        Destroy(gameObject);
        //        _canvDeath.SetActive(true);
        //        Cursor.lockState = CursorLockMode.None;
        //        Cursor.visible = true;
        //    }

        //    private void OnCollisionEnter(Collision collision)
        //    {
        //        if (collision.gameObject.tag == "Ground")
        //        {
        //            _ground = true;
        //        }
        //    }
    }