using UnityEngine;
using System.Diagnostics.CodeAnalysis;
namespace uSquid
{
	public class MonoBehaviourMessages
	{
		public readonly UnityObject UnityObject;
		public MonoBehaviourMessages(UnityObject unityObject)
		{
			UnityObject = unityObject;
		}
		public event UnityObjectEventArgs Awake;
		public event UnityObjectEventArgs FixedUpdate;
		public event UnityObjectEventArgs LateUpdate;
		public event OnAnimatorIKEventArgs OnAnimatorIK;
		public event UnityObjectEventArgs OnAnimatorMove;
		public event UnityObjectEventArgs OnApplicationFocus;
		public event UnityObjectEventArgs OnApplicationPause;
		public event UnityObjectEventArgs OnApplicationQuit;
		public event OnAudioFilterReadEventArgs OnAudioFilterRead;
		public event UnityObjectEventArgs OnBecameInvisible;
		public event UnityObjectEventArgs OnBecameVisible;
		public event OnCollisionEnterEventArgs OnCollisionEnter;
		public event OnCollisionEnter2DEventArgs OnCollisionEnter2D;
		public event OnCollisionExitEventArgs OnCollisionExit;
		public event OnCollisionExit2DEventArgs OnCollisionExit2D;
		public event OnCollisionStayEventArgs OnCollisionStay;
		public event OnCollisionStay2DEventArgs OnCollisionStay2D;
		public event UnityObjectEventArgs OnConnectedToServer;
		public event OnControllerColliderHitEventArgs OnControllerColliderHit;
		public event UnityObjectEventArgs OnDestroy;
		public event UnityObjectEventArgs OnDisable;
		public event UnityObjectEventArgs OnDrawGizmos;
		public event UnityObjectEventArgs OnDrawGizmosSelected;
		public event UnityObjectEventArgs OnEnable;
		public event UnityObjectEventArgs OnGUI;
		public event OnJointBreakEventArgs OnJointBreak;
		public event OnLevelWasLoadedEventArgs OnLevelWasLoaded;
		public event UnityObjectEventArgs OnMouseDown;
		public event UnityObjectEventArgs OnMouseDrag;
		public event UnityObjectEventArgs OnMouseEnter;
		public event UnityObjectEventArgs OnMouseExit;
		public event UnityObjectEventArgs OnMouseOver;
		public event UnityObjectEventArgs OnMouseUp;
		public event UnityObjectEventArgs OnMouseUpAsButton;
		public event OnParticleCollisionEventArgs OnParticleCollision;
		public event UnityObjectEventArgs OnPostRender;
		public event UnityObjectEventArgs OnPreCull;
		public event UnityObjectEventArgs OnPreRender;
		public event OnRenderImageEventArgs OnRenderImage;
		public event UnityObjectEventArgs OnRenderObject;
		public event UnityObjectEventArgs OnServerInitialized;
		public event UnityObjectEventArgs OnTransformChildrenChanged;
		public event UnityObjectEventArgs OnTransformParentChanged;
		public event OnTriggerEnterEventArgs OnTriggerEnter;
		public event OnTriggerEnter2DEventArgs OnTriggerEnter2D;
		public event OnTriggerExitEventArgs OnTriggerExit;
		public event OnTriggerExit2DEventArgs OnTriggerExit2D;
		public event OnTriggerStayEventArgs OnTriggerStay;
		public event OnTriggerStay2DEventArgs OnTriggerStay2D;
		public event UnityObjectEventArgs OnValidate;
		public event UnityObjectEventArgs OnWillRenderObject;
		public event UnityObjectEventArgs Reset;
		public event UnityObjectEventArgs Start;
		public event UnityObjectEventArgs Update;
		
		public delegate void UnityObjectEventArgs(UnityObject uObj);
		public delegate void OnAnimatorIKEventArgs(UnityObject uObj, int layerIndex);
		public delegate void OnAudioFilterReadEventArgs(UnityObject uObj, float[] data, int channels);
		public delegate void OnCollisionEnterEventArgs(UnityObject uObj, Collision collision);
		public delegate void OnCollisionEnter2DEventArgs(UnityObject uObj, Collision2D collision);
		public delegate void OnCollisionExitEventArgs(UnityObject uObj, Collision collision);
		public delegate void OnCollisionExit2DEventArgs(UnityObject uObj, Collision2D collision);
		public delegate void OnCollisionStayEventArgs(UnityObject uObj, Collision collision);
		public delegate void OnCollisionStay2DEventArgs(UnityObject uObj, Collision2D collision);
		public delegate void OnControllerColliderHitEventArgs(UnityObject uObj, ControllerColliderHit hit);
		public delegate void OnJointBreakEventArgs(UnityObject uObj, float breakForce);
		public delegate void OnLevelWasLoadedEventArgs(UnityObject uObj, int level);
		public delegate void OnParticleCollisionEventArgs(UnityObject uObj, GameObject other);
		public delegate void OnRenderImageEventArgs(UnityObject uObj, RenderTexture src, RenderTexture dest);
		public delegate void OnTriggerEnterEventArgs(UnityObject uObj, Collider other);
		public delegate void OnTriggerEnter2DEventArgs(UnityObject uObj, Collider2D other);
		public delegate void OnTriggerExitEventArgs(UnityObject uObj, Collider other);
		public delegate void OnTriggerExit2DEventArgs(UnityObject uObj, Collider2D other);
		public delegate void OnTriggerStayEventArgs(UnityObject uObj, Collider other);
		public delegate void OnTriggerStay2DEventArgs(UnityObject uObj, Collider2D other);
		
		[SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Justification = "Firing events is the appropriate usage of \"Fire\"")]
		public void FireAwake()
		{
			if (Awake != null)
			{
				Awake(UnityObject);
			}
		}
		public void ClearAwake()
		{
			Awake = null;
		}
		[SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Justification = "Firing events is the appropriate usage of \"Fire\"")]
		public void FireFixedUpdate()
		{
			if (FixedUpdate != null)
			{
				FixedUpdate(UnityObject);
			}
		}
		public void ClearFixedUpdate()
		{
			FixedUpdate = null;
		}
		[SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Justification = "Firing events is the appropriate usage of \"Fire\"")]
		public void FireLateUpdate()
		{
			if (LateUpdate != null)
			{
				LateUpdate(UnityObject);
			}
		}
		public void ClearLateUpdate()
		{
			LateUpdate = null;
		}
		[SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Justification = "Firing events is the appropriate usage of \"Fire\"")]
		public void FireOnAnimatorIK(int layerIndex)
		{
			if (OnAnimatorIK != null)
			{
				OnAnimatorIK(UnityObject, layerIndex);
			}
		}
		public void ClearOnAnimatorIK()
		{
			OnAnimatorIK = null;
		}
		[SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Justification = "Firing events is the appropriate usage of \"Fire\"")]
		public void FireOnAnimatorMove()
		{
			if (OnAnimatorMove != null)
			{
				OnAnimatorMove(UnityObject);
			}
		}
		public void ClearOnAnimatorMove()
		{
			OnAnimatorMove = null;
		}
		[SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Justification = "Firing events is the appropriate usage of \"Fire\"")]
		public void FireOnApplicationFocus()
		{
			if (OnApplicationFocus != null)
			{
				OnApplicationFocus(UnityObject);
			}
		}
		public void ClearOnApplicationFocus()
		{
			OnApplicationFocus = null;
		}
		[SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Justification = "Firing events is the appropriate usage of \"Fire\"")]
		public void FireOnApplicationPause()
		{
			if (OnApplicationPause != null)
			{
				OnApplicationPause(UnityObject);
			}
		}
		public void ClearOnApplicationPause()
		{
			OnApplicationPause = null;
		}
		[SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Justification = "Firing events is the appropriate usage of \"Fire\"")]
		public void FireOnApplicationQuit()
		{
			if (OnApplicationQuit != null)
			{
				OnApplicationQuit(UnityObject);
			}
		}
		public void ClearOnApplicationQuit()
		{
			OnApplicationQuit = null;
		}
		[SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Justification = "Firing events is the appropriate usage of \"Fire\"")]
		public void FireOnAudioFilterRead(float[] data, int channels)
		{
			if (OnAudioFilterRead != null)
			{
				OnAudioFilterRead(UnityObject, data, channels);
			}
		}
		public void ClearOnAudioFilterRead()
		{
			OnAudioFilterRead = null;
		}
		[SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Justification = "Firing events is the appropriate usage of \"Fire\"")]
		public void FireOnBecameInvisible()
		{
			if (OnBecameInvisible != null)
			{
				OnBecameInvisible(UnityObject);
			}
		}
		public void ClearOnBecameInvisible()
		{
			OnBecameInvisible = null;
		}
		[SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Justification = "Firing events is the appropriate usage of \"Fire\"")]
		public void FireOnBecameVisible()
		{
			if (OnBecameVisible != null)
			{
				OnBecameVisible(UnityObject);
			}
		}
		public void ClearOnBecameVisible()
		{
			OnBecameVisible = null;
		}
		[SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Justification = "Firing events is the appropriate usage of \"Fire\"")]
		public void FireOnCollisionEnter(Collision collision)
		{
			if (OnCollisionEnter != null)
			{
				OnCollisionEnter(UnityObject, collision);
			}
		}
		public void ClearOnCollisionEnter()
		{
			OnCollisionEnter = null;
		}
		[SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Justification = "Firing events is the appropriate usage of \"Fire\"")]
		public void FireOnCollisionEnter2D(Collision2D collision)
		{
			if (OnCollisionEnter2D != null)
			{
				OnCollisionEnter2D(UnityObject, collision);
			}
		}
		public void ClearOnCollisionEnter2D()
		{
			OnCollisionEnter2D = null;
		}
		[SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Justification = "Firing events is the appropriate usage of \"Fire\"")]
		public void FireOnCollisionExit(Collision collision)
		{
			if (OnCollisionExit != null)
			{
				OnCollisionExit(UnityObject, collision);
			}
		}
		public void ClearOnCollisionExit()
		{
			OnCollisionExit = null;
		}
		[SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Justification = "Firing events is the appropriate usage of \"Fire\"")]
		public void FireOnCollisionExit2D(Collision2D collision)
		{
			if (OnCollisionExit2D != null)
			{
				OnCollisionExit2D(UnityObject, collision);
			}
		}
		public void ClearOnCollisionExit2D()
		{
			OnCollisionExit2D = null;
		}
		[SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Justification = "Firing events is the appropriate usage of \"Fire\"")]
		public void FireOnCollisionStay(Collision collision)
		{
			if (OnCollisionStay != null)
			{
				OnCollisionStay(UnityObject, collision);
			}
		}
		public void ClearOnCollisionStay()
		{
			OnCollisionStay = null;
		}
		[SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Justification = "Firing events is the appropriate usage of \"Fire\"")]
		public void FireOnCollisionStay2D(Collision2D collision)
		{
			if (OnCollisionStay2D != null)
			{
				OnCollisionStay2D(UnityObject, collision);
			}
		}
		public void ClearOnCollisionStay2D()
		{
			OnCollisionStay2D = null;
		}
		[SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Justification = "Firing events is the appropriate usage of \"Fire\"")]
		public void FireOnConnectedToServer()
		{
			if (OnConnectedToServer != null)
			{
				OnConnectedToServer(UnityObject);
			}
		}
		public void ClearOnConnectedToServer()
		{
			OnConnectedToServer = null;
		}
		[SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Justification = "Firing events is the appropriate usage of \"Fire\"")]
		public void FireOnControllerColliderHit(ControllerColliderHit hit)
		{
			if (OnControllerColliderHit != null)
			{
				OnControllerColliderHit(UnityObject, hit);
			}
		}
		public void ClearOnControllerColliderHit()
		{
			OnControllerColliderHit = null;
		}
		[SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Justification = "Firing events is the appropriate usage of \"Fire\"")]
		public void FireOnDestroy()
		{
			if (OnDestroy != null)
			{
				OnDestroy(UnityObject);
			}
		}
		public void ClearOnDestroy()
		{
			OnDestroy = null;
		}
		[SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Justification = "Firing events is the appropriate usage of \"Fire\"")]
		public void FireOnDisable()
		{
			if (OnDisable != null)
			{
				OnDisable(UnityObject);
			}
		}
		public void ClearOnDisable()
		{
			OnDisable = null;
		}
		[SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Justification = "Firing events is the appropriate usage of \"Fire\"")]
		public void FireOnDrawGizmos()
		{
			if (OnDrawGizmos != null)
			{
				OnDrawGizmos(UnityObject);
			}
		}
		public void ClearOnDrawGizmos()
		{
			OnDrawGizmos = null;
		}
		[SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Justification = "Firing events is the appropriate usage of \"Fire\"")]
		public void FireOnDrawGizmosSelected()
		{
			if (OnDrawGizmosSelected != null)
			{
				OnDrawGizmosSelected(UnityObject);
			}
		}
		public void ClearOnDrawGizmosSelected()
		{
			OnDrawGizmosSelected = null;
		}
		[SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Justification = "Firing events is the appropriate usage of \"Fire\"")]
		public void FireOnEnable()
		{
			if (OnEnable != null)
			{
				OnEnable(UnityObject);
			}
		}
		public void ClearOnEnable()
		{
			OnEnable = null;
		}
		[SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Justification = "Firing events is the appropriate usage of \"Fire\"")]
		public void FireOnGUI()
		{
			if (OnGUI != null)
			{
				OnGUI(UnityObject);
			}
		}
		public void ClearOnGUI()
		{
			OnGUI = null;
		}
		[SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Justification = "Firing events is the appropriate usage of \"Fire\"")]
		public void FireOnJointBreak(float breakForce)
		{
			if (OnJointBreak != null)
			{
				OnJointBreak(UnityObject, breakForce);
			}
		}
		public void ClearOnJointBreak()
		{
			OnJointBreak = null;
		}
		[SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Justification = "Firing events is the appropriate usage of \"Fire\"")]
		public void FireOnLevelWasLoaded(int level)
		{
			if (OnLevelWasLoaded != null)
			{
				OnLevelWasLoaded(UnityObject, level);
			}
		}
		public void ClearOnLevelWasLoaded()
		{
			OnLevelWasLoaded = null;
		}
		[SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Justification = "Firing events is the appropriate usage of \"Fire\"")]
		public void FireOnMouseDown()
		{
			if (OnMouseDown != null)
			{
				OnMouseDown(UnityObject);
			}
		}
		public void ClearOnMouseDown()
		{
			OnMouseDown = null;
		}
		[SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Justification = "Firing events is the appropriate usage of \"Fire\"")]
		public void FireOnMouseDrag()
		{
			if (OnMouseDrag != null)
			{
				OnMouseDrag(UnityObject);
			}
		}
		public void ClearOnMouseDrag()
		{
			OnMouseDrag = null;
		}
		[SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Justification = "Firing events is the appropriate usage of \"Fire\"")]
		public void FireOnMouseEnter()
		{
			if (OnMouseEnter != null)
			{
				OnMouseEnter(UnityObject);
			}
		}
		public void ClearOnMouseEnter()
		{
			OnMouseEnter = null;
		}
		[SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Justification = "Firing events is the appropriate usage of \"Fire\"")]
		public void FireOnMouseExit()
		{
			if (OnMouseExit != null)
			{
				OnMouseExit(UnityObject);
			}
		}
		public void ClearOnMouseExit()
		{
			OnMouseExit = null;
		}
		[SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Justification = "Firing events is the appropriate usage of \"Fire\"")]
		public void FireOnMouseOver()
		{
			if (OnMouseOver != null)
			{
				OnMouseOver(UnityObject);
			}
		}
		public void ClearOnMouseOver()
		{
			OnMouseOver = null;
		}
		[SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Justification = "Firing events is the appropriate usage of \"Fire\"")]
		public void FireOnMouseUp()
		{
			if (OnMouseUp != null)
			{
				OnMouseUp(UnityObject);
			}
		}
		public void ClearOnMouseUp()
		{
			OnMouseUp = null;
		}
		[SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Justification = "Firing events is the appropriate usage of \"Fire\"")]
		public void FireOnMouseUpAsButton()
		{
			if (OnMouseUpAsButton != null)
			{
				OnMouseUpAsButton(UnityObject);
			}
		}
		public void ClearOnMouseUpAsButton()
		{
			OnMouseUpAsButton = null;
		}
		[SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Justification = "Firing events is the appropriate usage of \"Fire\"")]
		public void FireOnParticleCollision(GameObject other)
		{
			if (OnParticleCollision != null)
			{
				OnParticleCollision(UnityObject, other);
			}
		}
		public void ClearOnParticleCollision()
		{
			OnParticleCollision = null;
		}
		
		[SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Justification = "Firing events is the appropriate usage of \"Fire\"")]
		public void FireOnPostRender()
		{
			if (OnPostRender != null)
			{
				OnPostRender(UnityObject);
			}
		}
		public void ClearOnPostRender()
		{
			OnPostRender = null;
		}
		[SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Justification = "Firing events is the appropriate usage of \"Fire\"")]
		public void FireOnPreCull()
		{
			if (OnPreCull != null)
			{
				OnPreCull(UnityObject);
			}
		}
		public void ClearOnPreCull()
		{
			OnPreCull = null;
		}
		[SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Justification = "Firing events is the appropriate usage of \"Fire\"")]
		public void FireOnPreRender()
		{
			if (OnPreRender != null)
			{
				OnPreRender(UnityObject);
			}
		}
		public void ClearOnPreRender()
		{
			OnPreRender = null;
		}
		[SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Justification = "Firing events is the appropriate usage of \"Fire\"")]
		public void FireOnRenderImage(RenderTexture src, RenderTexture dest)
		{
			if (OnRenderImage != null)
			{
				OnRenderImage(UnityObject, src, dest);
			}
		}
		public void ClearOnRenderImage()
		{
			OnRenderImage = null;
		}
		[SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Justification = "Firing events is the appropriate usage of \"Fire\"")]
		public void FireOnRenderObject()
		{
			if (OnRenderObject != null)
			{
				OnRenderObject(UnityObject);
			}
		}
		public void ClearOnRenderObject()
		{
			OnRenderObject = null;
		}
		[SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Justification = "Firing events is the appropriate usage of \"Fire\"")]
		public void FireOnServerInitialized()
		{
			if (OnServerInitialized != null)
			{
				OnServerInitialized(UnityObject);
			}
		}
		public void ClearOnServerInitialized()
		{
			OnServerInitialized = null;
		}
		[SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Justification = "Firing events is the appropriate usage of \"Fire\"")]
		public void FireOnTransformChildrenChanged()
		{
			if (OnTransformChildrenChanged != null)
			{
				OnTransformChildrenChanged(UnityObject);
			}
		}
		public void ClearOnTransformChildrenChanged()
		{
			OnTransformChildrenChanged = null;
		}
		[SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Justification = "Firing events is the appropriate usage of \"Fire\"")]
		public void FireOnTransformParentChanged()
		{
			if (OnTransformParentChanged != null)
			{
				OnTransformParentChanged(UnityObject);
			}
		}
		public void ClearOnTransformParentChanged()
		{
			OnTransformParentChanged = null;
		}
		[SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Justification = "Firing events is the appropriate usage of \"Fire\"")]
		public void FireOnTriggerEnter(Collider other)
		{
			if (OnTriggerEnter != null)
			{
				OnTriggerEnter(UnityObject, other);
			}
		}
		public void ClearOnTriggerEnter()
		{
			OnTriggerEnter = null;
		}
		[SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Justification = "Firing events is the appropriate usage of \"Fire\"")]
		public void FireOnTriggerEnter2D(Collider2D other)
		{
			if (OnTriggerEnter2D != null)
			{
				OnTriggerEnter2D(UnityObject, other);
			}
		}
		public void ClearOnTriggerEnter2D()
		{
			OnTriggerEnter2D = null;
		}
		[SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Justification = "Firing events is the appropriate usage of \"Fire\"")]
		public void FireOnTriggerExit(Collider other)
		{
			if (OnTriggerExit != null)
			{
				OnTriggerExit(UnityObject, other);
			}
		}
		public void ClearOnTriggerExit()
		{
			OnTriggerExit = null;
		}
		[SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Justification = "Firing events is the appropriate usage of \"Fire\"")]
		public void FireOnTriggerExit2D(Collider2D other)
		{
			if (OnTriggerExit2D != null)
			{
				OnTriggerExit2D(UnityObject, other);
			}
		}
		public void ClearOnTriggerExit2D()
		{
			OnTriggerExit2D = null;
		}
		[SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Justification = "Firing events is the appropriate usage of \"Fire\"")]
		public void FireOnTriggerStay(Collider other)
		{
			if (OnTriggerStay != null)
			{
				OnTriggerStay(UnityObject, other);
			}
		}
		public void ClearOnTriggerStay()
		{
			OnTriggerStay = null;
		}
		[SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Justification = "Firing events is the appropriate usage of \"Fire\"")]
		public void FireOnTriggerStay2D(Collider2D other)
		{
			if (OnTriggerStay2D != null)
			{
				OnTriggerStay2D(UnityObject, other);
			}
		}
		public void ClearOnTriggerStay2D()
		{
			OnTriggerStay2D = null;
		}
		[SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Justification = "Firing events is the appropriate usage of \"Fire\"")]
		public void FireOnValidate()
		{
			if (OnValidate != null)
			{
				OnValidate(UnityObject);
			}
		}
		public void ClearOnValidate()
		{
			OnValidate = null;
		}
		[SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Justification = "Firing events is the appropriate usage of \"Fire\"")]
		public void FireOnWillRenderObject()
		{
			if (OnWillRenderObject != null)
			{
				OnWillRenderObject(UnityObject);
			}
		}
		public void ClearOnWillRenderObject()
		{
			OnWillRenderObject = null;
		}
		[SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Justification = "Firing events is the appropriate usage of \"Fire\"")]
		public void FireReset()
		{
			if (Reset != null)
			{
				Reset(UnityObject);
			}
		}
		public void ClearReset()
		{
			Reset = null;
		}
		[SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Justification = "Firing events is the appropriate usage of \"Fire\"")]
		public void FireStart()
		{
			if (Start != null)
			{
				Start(UnityObject);
			}
		}
		public void ClearStart()
		{
			Start = null;
		}
		[SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Justification = "Firing events is the appropriate usage of \"Fire\"")]
		public void FireUpdate()
		{
			if (Update != null)
			{
				Update(UnityObject);
			}
		}
		public void ClearUpdate()
		{
			Update = null;
		}
	}
}