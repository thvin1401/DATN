PGDMP                     
    |         	   DATN_QLBH    15.3    15.3 (    D           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            E           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            F           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            G           1262    347265 	   DATN_QLBH    DATABASE     �   CREATE DATABASE "DATN_QLBH" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'English_United States.1252';
    DROP DATABASE "DATN_QLBH";
                postgres    false            �            1259    347337    accessingrole    TABLE     �   CREATE TABLE public.accessingrole (
    id uuid NOT NULL,
    accounttype integer,
    functionid integer,
    createdatetime timestamp without time zone,
    updatedatetime timestamp without time zone
);
 !   DROP TABLE public.accessingrole;
       public         heap    postgres    false            �            1259    347346    account    TABLE       CREATE TABLE public.account (
    username character varying(255) NOT NULL,
    password character varying(255),
    userinfoid uuid,
    isenabled boolean,
    accounttype integer,
    createdatetime timestamp without time zone,
    updatedatetime timestamp without time zone
);
    DROP TABLE public.account;
       public         heap    postgres    false            �            1259    347310    bill    TABLE     *  CREATE TABLE public.bill (
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
       public         heap    postgres    false            �            1259    347271 
   categories    TABLE     �   CREATE TABLE public.categories (
    id uuid NOT NULL,
    name character varying(255),
    isdeleted boolean,
    createdatetime timestamp without time zone,
    updatedatetime timestamp without time zone
);
    DROP TABLE public.categories;
       public         heap    postgres    false            �            1259    347320    debtmanager    TABLE     �  CREATE TABLE public.debtmanager (
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
       public         heap    postgres    false            �            1259    347325    note    TABLE        CREATE TABLE public.note (
    id uuid NOT NULL,
    message text,
    isdone boolean,
    isdeleted boolean,
    reminddatetime timestamp without time zone,
    createdatetime timestamp without time zone,
    updatedatetime timestamp without time zone
);
    DROP TABLE public.note;
       public         heap    postgres    false            �            1259    347315    payment    TABLE     @  CREATE TABLE public.payment (
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
       public         heap    postgres    false            �            1259    347305    productmanager    TABLE     !  CREATE TABLE public.productmanager (
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
       public         heap    postgres    false            �            1259    347266    products    TABLE     /  CREATE TABLE public.products (
    id uuid NOT NULL,
    name character varying(255),
    quantity integer,
    unitprice double precision,
    providerid uuid,
    isdeleted boolean,
    categoryid uuid,
    createdatetime timestamp without time zone,
    updatedatetime timestamp without time zone
);
    DROP TABLE public.products;
       public         heap    postgres    false            �            1259    347290    ranking    TABLE     �   CREATE TABLE public.ranking (
    id uuid NOT NULL,
    name character varying(255),
    isactive boolean,
    discount double precision,
    createdatetime timestamp without time zone,
    updatedatetime timestamp without time zone
);
    DROP TABLE public.ranking;
       public         heap    postgres    false            �            1259    347300    systempropery    TABLE     �   CREATE TABLE public.systempropery (
    name character varying(255) NOT NULL,
    value character varying(255),
    description character varying(255),
    createdatetime timestamp without time zone,
    updatedatetime timestamp without time zone
);
 !   DROP TABLE public.systempropery;
       public         heap    postgres    false            �            1259    347283    userinfo    TABLE     �  CREATE TABLE public.userinfo (
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
       public         heap    postgres    false            @          0    347337    accessingrole 
   TABLE DATA           d   COPY public.accessingrole (id, accounttype, functionid, createdatetime, updatedatetime) FROM stdin;
    public          postgres    false    224   �3       A          0    347346    account 
   TABLE DATA           y   COPY public.account (username, password, userinfoid, isenabled, accounttype, createdatetime, updatedatetime) FROM stdin;
    public          postgres    false    225   �3       <          0    347310    bill 
   TABLE DATA              COPY public.bill (receiptnumber, billtype, amount, discount, payamount, isdeleted, createdatetime, updatedatetime) FROM stdin;
    public          postgres    false    220   c4       7          0    347271 
   categories 
   TABLE DATA           Y   COPY public.categories (id, name, isdeleted, createdatetime, updatedatetime) FROM stdin;
    public          postgres    false    215   �4       >          0    347320    debtmanager 
   TABLE DATA           �   COPY public.debtmanager (id, userinfoid, receiptnumber, amount, interest, circle, payamount, isfullpaid, processeddatetime, paiddatetime, type, createdatetime, updatedatetime) FROM stdin;
    public          postgres    false    222   �4       ?          0    347325    note 
   TABLE DATA           n   COPY public.note (id, message, isdone, isdeleted, reminddatetime, createdatetime, updatedatetime) FROM stdin;
    public          postgres    false    223   �4       =          0    347315    payment 
   TABLE DATA           �   COPY public.payment (id, receiptnumber, amount, debtid, paymentmethod, paydatetime, paymenttype, createdatetime, updatedatetime) FROM stdin;
    public          postgres    false    221   �4       ;          0    347305    productmanager 
   TABLE DATA           �   COPY public.productmanager (id, receiptnumber, productid, quantity, unitprice, discount, createdatetime, updatedatetime) FROM stdin;
    public          postgres    false    219   �4       6          0    347266    products 
   TABLE DATA           �   COPY public.products (id, name, quantity, unitprice, providerid, isdeleted, categoryid, createdatetime, updatedatetime) FROM stdin;
    public          postgres    false    214   5       9          0    347290    ranking 
   TABLE DATA           _   COPY public.ranking (id, name, isactive, discount, createdatetime, updatedatetime) FROM stdin;
    public          postgres    false    217   .5       :          0    347300    systempropery 
   TABLE DATA           a   COPY public.systempropery (name, value, description, createdatetime, updatedatetime) FROM stdin;
    public          postgres    false    218   �5       8          0    347283    userinfo 
   TABLE DATA           �   COPY public.userinfo (id, name, address, phone, email, rankid, isactive, point, type, createdatetime, updatedatetime, birthday) FROM stdin;
    public          postgres    false    216   �5       �           2606    347341     accessingrole accessingrole_pkey 
   CONSTRAINT     ^   ALTER TABLE ONLY public.accessingrole
    ADD CONSTRAINT accessingrole_pkey PRIMARY KEY (id);
 J   ALTER TABLE ONLY public.accessingrole DROP CONSTRAINT accessingrole_pkey;
       public            postgres    false    224            �           2606    347352    account account_pkey 
   CONSTRAINT     X   ALTER TABLE ONLY public.account
    ADD CONSTRAINT account_pkey PRIMARY KEY (username);
 >   ALTER TABLE ONLY public.account DROP CONSTRAINT account_pkey;
       public            postgres    false    225            �           2606    347314    bill bill_pkey 
   CONSTRAINT     W   ALTER TABLE ONLY public.bill
    ADD CONSTRAINT bill_pkey PRIMARY KEY (receiptnumber);
 8   ALTER TABLE ONLY public.bill DROP CONSTRAINT bill_pkey;
       public            postgres    false    220            �           2606    347275    categories categories_pkey 
   CONSTRAINT     X   ALTER TABLE ONLY public.categories
    ADD CONSTRAINT categories_pkey PRIMARY KEY (id);
 D   ALTER TABLE ONLY public.categories DROP CONSTRAINT categories_pkey;
       public            postgres    false    215            �           2606    347324    debtmanager debtmanager_pkey 
   CONSTRAINT     Z   ALTER TABLE ONLY public.debtmanager
    ADD CONSTRAINT debtmanager_pkey PRIMARY KEY (id);
 F   ALTER TABLE ONLY public.debtmanager DROP CONSTRAINT debtmanager_pkey;
       public            postgres    false    222            �           2606    347331    note note_pkey 
   CONSTRAINT     L   ALTER TABLE ONLY public.note
    ADD CONSTRAINT note_pkey PRIMARY KEY (id);
 8   ALTER TABLE ONLY public.note DROP CONSTRAINT note_pkey;
       public            postgres    false    223            �           2606    347319    payment payment_pkey 
   CONSTRAINT     R   ALTER TABLE ONLY public.payment
    ADD CONSTRAINT payment_pkey PRIMARY KEY (id);
 >   ALTER TABLE ONLY public.payment DROP CONSTRAINT payment_pkey;
       public            postgres    false    221            �           2606    347309 "   productmanager productmanager_pkey 
   CONSTRAINT     `   ALTER TABLE ONLY public.productmanager
    ADD CONSTRAINT productmanager_pkey PRIMARY KEY (id);
 L   ALTER TABLE ONLY public.productmanager DROP CONSTRAINT productmanager_pkey;
       public            postgres    false    219            �           2606    347270    products products_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public.products
    ADD CONSTRAINT products_pkey PRIMARY KEY (id);
 @   ALTER TABLE ONLY public.products DROP CONSTRAINT products_pkey;
       public            postgres    false    214            �           2606    347294    ranking ranking_pkey 
   CONSTRAINT     R   ALTER TABLE ONLY public.ranking
    ADD CONSTRAINT ranking_pkey PRIMARY KEY (id);
 >   ALTER TABLE ONLY public.ranking DROP CONSTRAINT ranking_pkey;
       public            postgres    false    217            �           2606    347345     systempropery systempropery_pkey 
   CONSTRAINT     `   ALTER TABLE ONLY public.systempropery
    ADD CONSTRAINT systempropery_pkey PRIMARY KEY (name);
 J   ALTER TABLE ONLY public.systempropery DROP CONSTRAINT systempropery_pkey;
       public            postgres    false    218            �           2606    347289    userinfo userinfo_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public.userinfo
    ADD CONSTRAINT userinfo_pkey PRIMARY KEY (id);
 @   ALTER TABLE ONLY public.userinfo DROP CONSTRAINT userinfo_pkey;
       public            postgres    false    216            @      x������ � �      A   p   x�+���(��4���,�4 Q1~\%��)�����n%���j��f�&�)�ɆfI�&����I�f��i�I&Ɩ�f`S��Ltu����W� �U      <      x������ � �      7      x������ � �      >      x������ � �      ?      x������ � �      =      x������ � �      ;      x������ � �      6      x������ � �      9   �   x�mι�0Dј�B@����N �g���|�L�v=��e8L=���M��\P\�
j���ax�,@��3˙yբ�Ѫ��QA��d'+Uu����qwZ(y�"IK��r=n��0s`��&-��?����_Y�x�c�oS�<d      :      x������ � �      8   {   x�u�1�0Eg���+;�01� �,I�&M���[!`�����<+]%\p`M(�;�*oo>�&D%�K�������c�9?Ke9�S,�nh��q`Z��	2#;K����"�귙sg�Y ��(-     