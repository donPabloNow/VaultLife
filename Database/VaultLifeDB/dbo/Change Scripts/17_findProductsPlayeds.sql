U S E   [ I n M e m o r y _ V a u l t L i f e S t a g e ]  
 G O  
 / * * * * * *   O b j e c t :     S t o r e d P r o c e d u r e   [ d b o ] . [ f i n d P r o d u c t P l a y e d s ]         S c r i p t   D a t e :   2 0 1 4 - 1 2 - 0 4   1 1 : 1 1 : 4 3   A M   * * * * * * /  
 S E T   A N S I _ N U L L S   O N  
 G O  
 S E T   Q U O T E D _ I D E N T I F I E R   O N  
 G O  
 A l t e r   P R O C E D U R E   [ d b o ] . [ f i n d P r o d u c t P l a y e d s ]   @ P r o d u c t I n G a m e I D   I N T  
 A S  
 B E G I N    
  
 	 - -   S E T   N O C O U N T   O N   a d d e d   t o   p r e v e n t   e x t r a   r e s u l t   s e t s   f r o m  
 	 - -   i n t e r f e r i n g   w i t h   S E L E C T   s t a t e m e n t s .  
 	  
  
 	 - -   I n s e r t   s t a t e m e n t s   f o r   p r o c e d u r e   h e r e  
  
 S E L E C T   [ P r o d u c t P l a y e d I D ]  
             , [ W i n n e r ]  
     F R O M   [ d b o ] . [ P r o d u c t P l a y e d ]  
     W H E R E   [ P r o d u c t I n G a m e I D ]   =   @ P r o d u c t I n G a m e I D   a n d   w i n n e r   =   0   o r d e r   b y   c l i c k i n t e r v a l   a s c  
  
 E N D  
  
 