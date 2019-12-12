using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AllConect : MonoBehaviour {

	  public GameObject t;
		public GameObject  show;
	  public GameObject f;
	  public InputField textBox1;
	  public InputField textBox2;
	  public Text label1;
	  public Text label2;
	  public Text Loses;
	  private string word1 = "";
	  private string word2 = "";
	  private int m = 0;
	  private int num =0;


	    // Start is called before the first frame update
	    void Start(){}
	    // Update is called once per frame
	    void Update(){}


	    public void b_EnterWord(){
			show.SetActive(false);
	     word1 = textBox1.text;
	     word1=word1.ToLower();
	     for(int n = 0; n<word1.Length; n++) {word2 +="*";}
	     label1.text=word2;
	     textBox1.text="";
	    }

	    public void b_EnterLetter(){

	      if(!(textBox2.text.Equals(""))) {
	          for(int i = 0; i<word1.Length; i++) {
	              if(textBox2.text.Equals(word1.Substring(i,1))) {
	                  word2=word2.Substring(0,i)+word1.Substring(i,1)+word2.Substring(i+1);
	                  label1.text=word2;
	                  m=1;

	              }
	          }
	          if(m==0) {
	              if(num<7) {
	                //написать то что доджно выполняться при неправильной букве
	                num++;
	                Loses.text=num.ToString();
	              }
	              else {
	                  Application.LoadLevel(2);
	                  num++;
	                  Loses.text=num.ToString();
	                  label2.text="YOU LOSE";
	              }
	          }
	          m=0;
	          if(word1.Equals(word2)) {
	              Application.LoadLevel(3);
	              t.SetActive(true);
	              f.SetActive(false);
	              label2.text="YOU WIN";
	          }
	          textBox2.text="";
	      }
	    }
	}
