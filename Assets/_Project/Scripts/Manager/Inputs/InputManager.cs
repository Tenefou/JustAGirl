using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    PlayerInput _input;
    public static InputManager Instance { private set; get;}

    private InputAction _moveAction;
    private InputAction _lookAroundAction;
    private InputAction _jumpAction;
    private InputAction _crouchAction;
    private InputAction _sprintAction;

    private void Awake()
    {
        _input = GetComponent<PlayerInput>();
        _moveAction = _input.actions.FindAction("Move");
        _lookAroundAction = _input.actions.FindAction("LookAround");
        _jumpAction = _input.actions.FindAction("Jump");
        _crouchAction = _input.actions.FindAction("Crouch");
        _sprintAction = _input.actions.FindAction("Sprint");

        if (Instance = null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void OnEnable()
    {
        _moveAction.Enable();
        _lookAroundAction.Enable();
        _jumpAction.Enable();
        _crouchAction.Enable();
        _sprintAction.Enable();
    }

    private void OnDisable()
    {
        _moveAction.Disable();
        _lookAroundAction.Disable();
        _jumpAction.Disable();
        _crouchAction.Disable();
        _sprintAction.Disable();
    }

    public InputAction MoveAction => _moveAction;
    public InputAction LookAroundAction => _lookAroundAction;
    public InputAction JumpAction => _jumpAction;
    public InputAction CrouchAction => _crouchAction;
    public InputAction SprintAction => _sprintAction;


}
