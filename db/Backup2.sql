PGDMP     3    2            
    |         	   DATN_QLBH    12.16    12.16 +    Y           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            Z           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            [           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            \           1262    1221884 	   DATN_QLBH    DATABASE     �   CREATE DATABASE "DATN_QLBH" WITH TEMPLATE = template0 ENCODING = 'UTF8' LC_COLLATE = 'English_United States.1252' LC_CTYPE = 'English_United States.1252';
    DROP DATABASE "DATN_QLBH";
                postgres    false            �            1259    1221885    accessingrole    TABLE     �   CREATE TABLE public.accessingrole (
    id uuid NOT NULL,
    accounttype integer,
    functionid integer,
    createdatetime timestamp without time zone,
    updatedatetime timestamp without time zone
);
 !   DROP TABLE public.accessingrole;
       public         heap    postgres    false            �            1259    1221888    account    TABLE       CREATE TABLE public.account (
    username character varying(255) NOT NULL,
    password character varying(255),
    userinfoid uuid,
    isenabled boolean,
    accounttype integer,
    createdatetime timestamp without time zone,
    updatedatetime timestamp without time zone
);
    DROP TABLE public.account;
       public         heap    postgres    false            �            1259    1221894    bill    TABLE     *  CREATE TABLE public.bill (
    receiptnumber integer NOT NULL,
    billtype integer,
    amount double precision,
    discount double precision,
    payamount double precision,
    isdeleted boolean,
    createdatetime timestamp without time zone,
    updatedatetime timestamp without time zone
);
    DROP TABLE public.bill;
       public         heap    postgres    false            �            1259    1221897 
   categories    TABLE     �   CREATE TABLE public.categories (
    id uuid NOT NULL,
    name character varying(255),
    isdeleted boolean,
    createdatetime timestamp without time zone,
    updatedatetime timestamp without time zone
);
    DROP TABLE public.categories;
       public         heap    postgres    false            �            1259    1221957    currencyexchange    TABLE     �   CREATE TABLE public.currencyexchange (
    name character varying NOT NULL,
    exchangerate double precision,
    type integer
);
 $   DROP TABLE public.currencyexchange;
       public         heap    postgres    false            �            1259    1221900    debtmanager    TABLE     �  CREATE TABLE public.debtmanager (
    id uuid NOT NULL,
    userinfoid uuid,
    receiptnumber integer,
    amount double precision,
    interest double precision,
    circle integer,
    payamount double precision,
    isfullpaid boolean,
    processeddatetime timestamp without time zone,
    paiddatetime timestamp without time zone,
    type integer,
    createdatetime timestamp without time zone,
    updatedatetime timestamp without time zone
);
    DROP TABLE public.debtmanager;
       public         heap    postgres    false            �            1259    1221903    note    TABLE        CREATE TABLE public.note (
    id uuid NOT NULL,
    message text,
    isdone boolean,
    isdeleted boolean,
    reminddatetime timestamp without time zone,
    createdatetime timestamp without time zone,
    updatedatetime timestamp without time zone
);
    DROP TABLE public.note;
       public         heap    postgres    false            �            1259    1221909    payment    TABLE     @  CREATE TABLE public.payment (
    id uuid NOT NULL,
    receiptnumber integer,
    amount double precision,
    debtid uuid,
    paymentmethod integer,
    paydatetime timestamp without time zone,
    paymenttype integer,
    createdatetime timestamp without time zone,
    updatedatetime timestamp without time zone
);
    DROP TABLE public.payment;
       public         heap    postgres    false            �            1259    1221912    productmanager    TABLE     !  CREATE TABLE public.productmanager (
    id uuid NOT NULL,
    receiptnumber integer,
    productid uuid,
    quantity integer,
    unitprice double precision,
    discount double precision,
    createdatetime timestamp without time zone,
    updatedatetime timestamp without time zone
);
 "   DROP TABLE public.productmanager;
       public         heap    postgres    false            �            1259    1221915    products    TABLE     s  CREATE TABLE public.products (
    id uuid NOT NULL,
    name character varying(255),
    quantity integer,
    unitprice double precision,
    providerid uuid,
    isdeleted boolean,
    categoryid uuid,
    createdatetime timestamp without time zone,
    updatedatetime timestamp without time zone,
    importdatetime timestamp without time zone,
    weight integer
);
    DROP TABLE public.products;
       public         heap    postgres    false            �            1259    1221918    ranking    TABLE     �   CREATE TABLE public.ranking (
    id uuid NOT NULL,
    name character varying(255),
    isactive boolean,
    discount double precision,
    createdatetime timestamp without time zone,
    updatedatetime timestamp without time zone
);
    DROP TABLE public.ranking;
       public         heap    postgres    false            �            1259    1221921    systempropery    TABLE     �   CREATE TABLE public.systempropery (
    name character varying(255) NOT NULL,
    value character varying(255),
    description character varying(255),
    createdatetime timestamp without time zone,
    updatedatetime timestamp without time zone
);
 !   DROP TABLE public.systempropery;
       public         heap    postgres    false            �            1259    1221927    userinfo    TABLE     �  CREATE TABLE public.userinfo (
    id uuid NOT NULL,
    name character varying(255),
    address character varying(255),
    phone character varying(50),
    email character varying(100),
    rankid uuid,
    isactive boolean,
    point integer,
    type integer,
    createdatetime timestamp without time zone,
    updatedatetime timestamp without time zone,
    birthday timestamp without time zone
);
    DROP TABLE public.userinfo;
       public         heap    postgres    false            J          0    1221885    accessingrole 
   TABLE DATA           d   COPY public.accessingrole (id, accounttype, functionid, createdatetime, updatedatetime) FROM stdin;
    public          postgres    false    202   �7       K          0    1221888    account 
   TABLE DATA           y   COPY public.account (username, password, userinfoid, isenabled, accounttype, createdatetime, updatedatetime) FROM stdin;
    public          postgres    false    203   �7       L          0    1221894    bill 
   TABLE DATA              COPY public.bill (receiptnumber, billtype, amount, discount, payamount, isdeleted, createdatetime, updatedatetime) FROM stdin;
    public          postgres    false    204   �8       M          0    1221897 
   categories 
   TABLE DATA           Y   COPY public.categories (id, name, isdeleted, createdatetime, updatedatetime) FROM stdin;
    public          postgres    false    205   �8       V          0    1221957    currencyexchange 
   TABLE DATA           D   COPY public.currencyexchange (name, exchangerate, type) FROM stdin;
    public          postgres    false    214   
9       N          0    1221900    debtmanager 
   TABLE DATA           �   COPY public.debtmanager (id, userinfoid, receiptnumber, amount, interest, circle, payamount, isfullpaid, processeddatetime, paiddatetime, type, createdatetime, updatedatetime) FROM stdin;
    public          postgres    false    206   M9       O          0    1221903    note 
   TABLE DATA           n   COPY public.note (id, message, isdone, isdeleted, reminddatetime, createdatetime, updatedatetime) FROM stdin;
    public          postgres    false    207   j9       P          0    1221909    payment 
   TABLE DATA           �   COPY public.payment (id, receiptnumber, amount, debtid, paymentmethod, paydatetime, paymenttype, createdatetime, updatedatetime) FROM stdin;
    public          postgres    false    208   �:       Q          0    1221912    productmanager 
   TABLE DATA           �   COPY public.productmanager (id, receiptnumber, productid, quantity, unitprice, discount, createdatetime, updatedatetime) FROM stdin;
    public          postgres    false    209   �:       R          0    1221915    products 
   TABLE DATA           �   COPY public.products (id, name, quantity, unitprice, providerid, isdeleted, categoryid, createdatetime, updatedatetime, importdatetime, weight) FROM stdin;
    public          postgres    false    210   �:       S          0    1221918    ranking 
   TABLE DATA           _   COPY public.ranking (id, name, isactive, discount, createdatetime, updatedatetime) FROM stdin;
    public          postgres    false    211   �;       T          0    1221921    systempropery 
   TABLE DATA           a   COPY public.systempropery (name, value, description, createdatetime, updatedatetime) FROM stdin;
    public          postgres    false    212   `<       U          0    1221927    userinfo 
   TABLE DATA           �   COPY public.userinfo (id, name, address, phone, email, rankid, isactive, point, type, createdatetime, updatedatetime, birthday) FROM stdin;
    public          postgres    false    213   }<       �
           2606    1221934     accessingrole accessingrole_pkey 
   CONSTRAINT     ^   ALTER TABLE ONLY public.accessingrole
    ADD CONSTRAINT accessingrole_pkey PRIMARY KEY (id);
 J   ALTER TABLE ONLY public.accessingrole DROP CONSTRAINT accessingrole_pkey;
       public            postgres    false    202            �
           2606    1221936    account account_pkey 
   CONSTRAINT     X   ALTER TABLE ONLY public.account
    ADD CONSTRAINT account_pkey PRIMARY KEY (username);
 >   ALTER TABLE ONLY public.account DROP CONSTRAINT account_pkey;
       public            postgres    false    203            �
           2606    1221938    bill bill_pkey 
   CONSTRAINT     W   ALTER TABLE ONLY public.bill
    ADD CONSTRAINT bill_pkey PRIMARY KEY (receiptnumber);
 8   ALTER TABLE ONLY public.bill DROP CONSTRAINT bill_pkey;
       public            postgres    false    204            �
           2606    1221940    categories categories_pkey 
   CONSTRAINT     X   ALTER TABLE ONLY public.categories
    ADD CONSTRAINT categories_pkey PRIMARY KEY (id);
 D   ALTER TABLE ONLY public.categories DROP CONSTRAINT categories_pkey;
       public            postgres    false    205            �
           2606    1221964 "   currencyexchange currencytype_pkey 
   CONSTRAINT     b   ALTER TABLE ONLY public.currencyexchange
    ADD CONSTRAINT currencytype_pkey PRIMARY KEY (name);
 L   ALTER TABLE ONLY public.currencyexchange DROP CONSTRAINT currencytype_pkey;
       public            postgres    false    214            �
           2606    1221942    debtmanager debtmanager_pkey 
   CONSTRAINT     Z   ALTER TABLE ONLY public.debtmanager
    ADD CONSTRAINT debtmanager_pkey PRIMARY KEY (id);
 F   ALTER TABLE ONLY public.debtmanager DROP CONSTRAINT debtmanager_pkey;
       public            postgres    false    206            �
           2606    1221944    note note_pkey 
   CONSTRAINT     L   ALTER TABLE ONLY public.note
    ADD CONSTRAINT note_pkey PRIMARY KEY (id);
 8   ALTER TABLE ONLY public.note DROP CONSTRAINT note_pkey;
       public            postgres    false    207            �
           2606    1221946    payment payment_pkey 
   CONSTRAINT     R   ALTER TABLE ONLY public.payment
    ADD CONSTRAINT payment_pkey PRIMARY KEY (id);
 >   ALTER TABLE ONLY public.payment DROP CONSTRAINT payment_pkey;
       public            postgres    false    208            �
           2606    1221948 "   productmanager productmanager_pkey 
   CONSTRAINT     `   ALTER TABLE ONLY public.productmanager
    ADD CONSTRAINT productmanager_pkey PRIMARY KEY (id);
 L   ALTER TABLE ONLY public.productmanager DROP CONSTRAINT productmanager_pkey;
       public            postgres    false    209            �
           2606    1221950    products products_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public.products
    ADD CONSTRAINT products_pkey PRIMARY KEY (id);
 @   ALTER TABLE ONLY public.products DROP CONSTRAINT products_pkey;
       public            postgres    false    210            �
           2606    1221952    ranking ranking_pkey 
   CONSTRAINT     R   ALTER TABLE ONLY public.ranking
    ADD CONSTRAINT ranking_pkey PRIMARY KEY (id);
 >   ALTER TABLE ONLY public.ranking DROP CONSTRAINT ranking_pkey;
       public            postgres    false    211            �
           2606    1221954     systempropery systempropery_pkey 
   CONSTRAINT     `   ALTER TABLE ONLY public.systempropery
    ADD CONSTRAINT systempropery_pkey PRIMARY KEY (name);
 J   ALTER TABLE ONLY public.systempropery DROP CONSTRAINT systempropery_pkey;
       public            postgres    false    212            �
           2606    1221956    userinfo userinfo_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public.userinfo
    ADD CONSTRAINT userinfo_pkey PRIMARY KEY (id);
 @   ALTER TABLE ONLY public.userinfo DROP CONSTRAINT userinfo_pkey;
       public            postgres    false    213            J      x������ � �      K   �   x�m�1�0Eg�LlFv�&1SY{�.IT�!E���]R����7���5�	�*�vCo�4�i��ӭ�z�tk�o���QM�`Q��爎��4::�+�� 3�=]�9�����,Υ��sF	EPK��˅5���3���� 1�      L      x������ � �      M   T   x�KJ�H43�4׵��4�516�еH5)�&�F&�iIɜΉ%���E�
��i�FF&�����
��V&&V��ĸb���� i�j      V   3   x�s�4�050�4��.�44 ��B�]8��@�F\a~.���\1z\\\ נM      N      x������ � �      O     x�m�;n�0k�����]֩s�4�6)R$@�ځ���7�	�:b�H-�D���)�X,��і���;}����ȓ "���["�gzc�ĂL찔�e0�v�P0�
�q�҆�1v>�n�ޟ�pԉ84r��d�p� �dȳYt�u�]��{]��P���I
�,��5륎@Z`�(tT��հѮ㓺�%>�lI�.ۦ%����F�CPݴ��+���\}6�%yM������6�� �yz��^=�>U<�n{��ug���$߅����/V��      P      x������ � �      Q      x������ � �      R   �   x���9NAи��F޺m�)8 I/�	�����堂ҫJȈu��Rо:�Ü�����׏��5?H��:.�"�!|7P�bA�t����.�{o�A�"�W�/�`��cFV �ɩz
��G�Sa�M��k���edO�8���B,����$���ь�jK݋�b7"m���ў~��W.lb��D-�/��mmx�����'�����r�7k~��      S   �   x�mι�0Dј�B@����N �g���|�L�v=��e8L=���M��\P\�
j���ax�,@��3˙yբ�Ѫ��QA��d'+Uu����qwZ(y�"IK��r=n��0s`��&-��?����_Y�x�c�oS�<d      T      x������ � �      U     x����JA�ϳO1`$�Ig&�<�Г,��evw��`w�t�����b�`B�O��ē���CG�F
 �Zp�Ⱦe+ѡZ�Ӡ��\����(��q��o��8>_we��=�B�uPXӠa 2�歾��r�O��cb�� -�2���B0�e�6�j���^ͳ~���c��}�ҫG���:E}WF�V*�Aq���<�ϙ���C'<��X+$dLݢ�X�W@���s��z_�c�����競���Ek��^��^:`k�D����ڐ��Ě�GkO�MӼ ꗰ     