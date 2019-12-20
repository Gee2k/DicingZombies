using UnityEngine;

abstract public class DiceBehaviour : MonoBehaviour
{
    protected enum Sides { ceiling, floor, north, south, east, west, unknown };
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            float dirX = Random.Range(0, 30);
            float dirY = Random.Range(0, 30);
            float dirZ = Random.Range(0, 30);
            transform.position = new Vector3(0, 0.2f, 0);
            transform.rotation = Quaternion.identity;
            rb.AddForce(transform.up * 10);
            rb.AddTorque(dirX, dirY, dirZ);
        }
    }

    public bool IsNotMoving()
    {
        return rb.IsSleeping();
    }

    public DiceValues getValue()
    {
        Sides currentSide = Sides.south;
        if (IsSideFacingUp(transform.up))
        {
            currentSide = Sides.ceiling;
        }
        else if (IsSideFacingUp(-transform.up))
        {
            currentSide = Sides.floor;
        }
        else if (IsSideFacingUp(transform.forward))
        {
            currentSide = Sides.north;
        }
        else if (IsSideFacingUp(-transform.forward))
        {
            currentSide = Sides.south;
        }
        else if (IsSideFacingUp(transform.right))
        {
            currentSide = Sides.east;
        }
        else if (IsSideFacingUp(-transform.right))
        {
            currentSide = Sides.west;
        }
        return getValueOf(currentSide);
    }

    private bool IsSideFacingUp ( Vector3 direction)
    {
        RaycastHit hit;
        Physics.Raycast(transform.position, direction, out hit);
        return hit.transform.tag == "game_ceiling";
    }

    abstract protected DiceValues getValueOf(Sides side);
    
}
