using UnityEngine;
public class UnityObjectBehaviour : MonoBehaviour
{
	public UnityObject UnityObject { get; private set; }
	public void SetUnityObject(UnityObject unityObject)
	{
		UnityObject = unityObject;
	}
	public void Awake()
	{
		//this.UnityObject.u.FireAwake();
	}
	public void FixedUpdate()
	{
		this.UnityObject.u.FireFixedUpdate();
	}
	public void LateUpdate()
	{
		this.UnityObject.u.FireLateUpdate();
	}
	public void OnAnimatorIK(int layerIndex)
	{
		this.UnityObject.u.FireOnAnimatorIK(layerIndex);
	}
	public void OnAnimatorMove()
	{
		this.UnityObject.u.FireOnAnimatorMove();
	}
	public void OnApplicationFocus()
	{
		this.UnityObject.u.FireOnApplicationFocus();
	}
	public void OnApplicationPause()
	{
		this.UnityObject.u.FireOnApplicationPause();
	}
	public void OnApplicationQuit()
	{
		this.UnityObject.u.FireOnApplicationQuit();
	}
	public void OnAudioFilterRead(float[] data, int channels)
	{
		this.UnityObject.u.FireOnAudioFilterRead(data, channels);
	}
	public void OnBecameInvisible()
	{
		this.UnityObject.u.FireOnBecameInvisible();
	}
	public void OnBecameVisible()
	{
		this.UnityObject.u.FireOnBecameVisible();
	}
	public void OnCollisionEnter(Collision collision)
	{
		this.UnityObject.u.FireOnCollisionEnter(collision);
	}
	public void OnCollisionEnter2D(Collision2D collision)
	{
		this.UnityObject.u.FireOnCollisionEnter2D(collision);
	}
	public void OnCollisionExit(Collision collision)
	{
		this.UnityObject.u.FireOnCollisionExit(collision);
	}
	public void OnCollisionExit2D(Collision2D collision)
	{
		this.UnityObject.u.FireOnCollisionExit2D(collision);
	}
	public void OnCollisionStay(Collision collision)
	{
		this.UnityObject.u.FireOnCollisionStay(collision);
	}
	public void OnCollisionStay2D(Collision2D collision)
	{
		this.UnityObject.u.FireOnCollisionStay2D(collision);
	}
	public void OnConnectedToServer()
	{
		this.UnityObject.u.FireOnConnectedToServer();
	}
	public void OnControllerColliderHit(ControllerColliderHit hit)
	{
		this.UnityObject.u.FireOnControllerColliderHit(hit);
	}
	public void OnDestroy()
	{
		this.UnityObject.u.FireOnDestroy();
	}
	public void OnDisable()
	{
		this.UnityObject.u.FireOnDisable();
	}
	public void OnDrawGizmos()
	{
		this.UnityObject.u.FireOnDrawGizmos();
	}
	public void OnDrawGizmosSelected()
	{
		this.UnityObject.u.FireOnDrawGizmosSelected();
	}
	public void OnEnable()
	{
        if(this.UnityObject != null)
            this.UnityObject.u.FireOnEnable();
	}
	public void OnGUI()
	{
		this.UnityObject.u.FireOnGUI();
	}
	public void OnJointBreak(float breakForce)
	{
		this.UnityObject.u.FireOnJointBreak(breakForce);
	}
	public void OnLevelWasLoaded(int level)
	{
		this.UnityObject.u.FireOnLevelWasLoaded(level);
	}
	public void OnMouseDown()
	{
		this.UnityObject.u.FireOnMouseDown();
	}
	public void OnMouseDrag()
	{
		this.UnityObject.u.FireOnMouseDrag();
	}
	public void OnMouseEnter()
	{
		this.UnityObject.u.FireOnMouseEnter();
	}
	public void OnMouseExit()
	{
		this.UnityObject.u.FireOnMouseExit();
	}
	public void OnMouseOver()
	{
		this.UnityObject.u.FireOnMouseOver();
	}
	public void OnMouseUp()
	{
		this.UnityObject.u.FireOnMouseUp();
	}
	public void OnMouseUpAsButton()
	{
		this.UnityObject.u.FireOnMouseUpAsButton();
	}
	public void OnParticleCollision(GameObject other)
	{
		this.UnityObject.u.FireOnParticleCollision(other);
	}
	public void OnPostRender()
	{
		this.UnityObject.u.FireOnPostRender();
	}
	public void OnPreCull()
	{
		this.UnityObject.u.FireOnPreCull();
	}
	public void OnPreRender()
	{
		this.UnityObject.u.FireOnPreRender();
	}
	public void OnRenderImage(RenderTexture src, RenderTexture dest)
	{
		this.UnityObject.u.FireOnRenderImage(src, dest);
	}
	public void OnRenderObject()
	{
		this.UnityObject.u.FireOnRenderObject();
	}
	public void OnServerInitialized()
	{
		this.UnityObject.u.FireOnServerInitialized();
	}
	public void OnTransformChildrenChanged()
	{
		this.UnityObject.u.FireOnTransformChildrenChanged();
	}
	public void OnTransformParentChanged()
	{
		this.UnityObject.u.FireOnTransformParentChanged();
	}
	public void OnTriggerEnter(Collider other)
	{
		this.UnityObject.u.FireOnTriggerEnter(other);
	}
	public void OnTriggerEnter2D(Collider2D other)
	{
		this.UnityObject.u.FireOnTriggerEnter2D(other);
	}
	public void OnTriggerExit(Collider other)
	{
		this.UnityObject.u.FireOnTriggerExit(other);
	}
	public void OnTriggerExit2D(Collider2D other)
	{
		this.UnityObject.u.FireOnTriggerExit2D(other);
	}
	public void OnTriggerStay(Collider other)
	{
		this.UnityObject.u.FireOnTriggerStay(other);
	}
	public void OnTriggerStay2D(Collider2D other)
	{
		this.UnityObject.u.FireOnTriggerStay2D(other);
	}
	public void OnValidate()
	{
		this.UnityObject.u.FireOnValidate();
	}
	public void OnWillRenderObject()
	{
		this.UnityObject.u.FireOnWillRenderObject();
	}
	public void Reset()
	{
		this.UnityObject.u.FireReset();
	}
	public void Start()
	{
		this.UnityObject.u.FireStart();
	}
	public void Update()
	{
		this.UnityObject.u.FireUpdate();
	}
}