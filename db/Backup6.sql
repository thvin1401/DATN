PGDMP                     
    |         	   DATN_QLBH    12.16    12.16 -    \           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            ]           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            ^           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            _           1262    1221884 	   DATN_QLBH    DATABASE     �   CREATE DATABASE "DATN_QLBH" WITH TEMPLATE = template0 ENCODING = 'UTF8' LC_COLLATE = 'English_United States.1252' LC_CTYPE = 'English_United States.1252';
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
       public         heap    postgres    false            �            1259    1221894    bill    TABLE     )  CREATE TABLE public.bill (
    receiptnumber integer NOT NULL,
    amount double precision,
    discount double precision,
    payamount double precision,
    isdeleted boolean,
    createdatetime timestamp without time zone,
    updatedatetime timestamp without time zone,
    userinfoid uuid
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
       public         heap    postgres    false            �            1259    1221978    debtmanager    TABLE     �  CREATE TABLE public.debtmanager (
    id uuid NOT NULL,
    receiptnumber integer,
    interest double precision,
    circle integer,
    status integer,
    processeddatetime timestamp without time zone,
    paiddatetime timestamp without time zone,
    type integer,
    createdatetime timestamp without time zone,
    updatedatetime timestamp without time zone,
    paidbeforetime timestamp without time zone
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
       public         heap    postgres    false            �            1259    1221909    payment    TABLE     �   CREATE TABLE public.payment (
    id uuid NOT NULL,
    receiptnumber integer,
    amount double precision,
    userinfoid uuid,
    paymentmethod integer,
    paydatetime timestamp without time zone,
    createdatetime timestamp without time zone
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
       public         heap    postgres    false            �            1259    1221918    ranking    TABLE       CREATE TABLE public.ranking (
    id uuid NOT NULL,
    name character varying(255),
    isactive boolean,
    discount double precision,
    createdatetime timestamp without time zone,
    updatedatetime timestamp without time zone,
    achivepoint integer
);
    DROP TABLE public.ranking;
       public         heap    postgres    false            �            1259    1221965    receipt_number    SEQUENCE     �   CREATE SEQUENCE public.receipt_number
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    MAXVALUE 1000000
    CACHE 1
    CYCLE;
 %   DROP SEQUENCE public.receipt_number;
       public          postgres    false            �            1259    1221921    systempropery    TABLE     �   CREATE TABLE public.systempropery (
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
       public         heap    postgres    false            L          0    1221885    accessingrole 
   TABLE DATA           d   COPY public.accessingrole (id, accounttype, functionid, createdatetime, updatedatetime) FROM stdin;
    public          postgres    false    202   ]9       M          0    1221888    account 
   TABLE DATA           y   COPY public.account (username, password, userinfoid, isenabled, accounttype, createdatetime, updatedatetime) FROM stdin;
    public          postgres    false    203   z9       N          0    1221894    bill 
   TABLE DATA           �   COPY public.bill (receiptnumber, amount, discount, payamount, isdeleted, createdatetime, updatedatetime, userinfoid) FROM stdin;
    public          postgres    false    204   >:       O          0    1221897 
   categories 
   TABLE DATA           Y   COPY public.categories (id, name, isdeleted, createdatetime, updatedatetime) FROM stdin;
    public          postgres    false    205   �;       W          0    1221957    currencyexchange 
   TABLE DATA           D   COPY public.currencyexchange (name, exchangerate, type) FROM stdin;
    public          postgres    false    213    <       Y          0    1221978    debtmanager 
   TABLE DATA           �   COPY public.debtmanager (id, receiptnumber, interest, circle, status, processeddatetime, paiddatetime, type, createdatetime, updatedatetime, paidbeforetime) FROM stdin;
    public          postgres    false    215   C<       P          0    1221903    note 
   TABLE DATA           n   COPY public.note (id, message, isdone, isdeleted, reminddatetime, createdatetime, updatedatetime) FROM stdin;
    public          postgres    false    206   A>       Q          0    1221909    payment 
   TABLE DATA           t   COPY public.payment (id, receiptnumber, amount, userinfoid, paymentmethod, paydatetime, createdatetime) FROM stdin;
    public          postgres    false    207   �?       R          0    1221912    productmanager 
   TABLE DATA           �   COPY public.productmanager (id, receiptnumber, productid, quantity, unitprice, discount, createdatetime, updatedatetime) FROM stdin;
    public          postgres    false    208   �@       S          0    1221915    products 
   TABLE DATA           �   COPY public.products (id, name, quantity, unitprice, providerid, isdeleted, categoryid, createdatetime, updatedatetime, importdatetime, weight) FROM stdin;
    public          postgres    false    209   >B       T          0    1221918    ranking 
   TABLE DATA           l   COPY public.ranking (id, name, isactive, discount, createdatetime, updatedatetime, achivepoint) FROM stdin;
    public          postgres    false    210   ;C       U          0    1221921    systempropery 
   TABLE DATA           a   COPY public.systempropery (name, value, description, createdatetime, updatedatetime) FROM stdin;
    public          postgres    false    211   �C       V          0    1221927    userinfo 
   TABLE DATA           �   COPY public.userinfo (id, name, address, phone, email, rankid, isactive, point, type, createdatetime, updatedatetime, birthday) FROM stdin;
    public          postgres    false    212   �C       `           0    0    receipt_number    SEQUENCE SET     =   SELECT pg_catalog.setval('public.receipt_number', 32, true);
          public          postgres    false    214            �
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
       public            postgres    false    213            �
           2606    1221982    debtmanager debtmanager_pkey 
   CONSTRAINT     Z   ALTER TABLE ONLY public.debtmanager
    ADD CONSTRAINT debtmanager_pkey PRIMARY KEY (id);
 F   ALTER TABLE ONLY public.debtmanager DROP CONSTRAINT debtmanager_pkey;
       public            postgres    false    215            �
           2606    1221944    note note_pkey 
   CONSTRAINT     L   ALTER TABLE ONLY public.note
    ADD CONSTRAINT note_pkey PRIMARY KEY (id);
 8   ALTER TABLE ONLY public.note DROP CONSTRAINT note_pkey;
       public            postgres    false    206            �
           2606    1221946    payment payment_pkey 
   CONSTRAINT     R   ALTER TABLE ONLY public.payment
    ADD CONSTRAINT payment_pkey PRIMARY KEY (id);
 >   ALTER TABLE ONLY public.payment DROP CONSTRAINT payment_pkey;
       public            postgres    false    207            �
           2606    1221948 "   productmanager productmanager_pkey 
   CONSTRAINT     `   ALTER TABLE ONLY public.productmanager
    ADD CONSTRAINT productmanager_pkey PRIMARY KEY (id);
 L   ALTER TABLE ONLY public.productmanager DROP CONSTRAINT productmanager_pkey;
       public            postgres    false    208            �
           2606    1221950    products products_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public.products
    ADD CONSTRAINT products_pkey PRIMARY KEY (id);
 @   ALTER TABLE ONLY public.products DROP CONSTRAINT products_pkey;
       public            postgres    false    209            �
           2606    1221952    ranking ranking_pkey 
   CONSTRAINT     R   ALTER TABLE ONLY public.ranking
    ADD CONSTRAINT ranking_pkey PRIMARY KEY (id);
 >   ALTER TABLE ONLY public.ranking DROP CONSTRAINT ranking_pkey;
       public            postgres    false    210            �
           2606    1221954     systempropery systempropery_pkey 
   CONSTRAINT     `   ALTER TABLE ONLY public.systempropery
    ADD CONSTRAINT systempropery_pkey PRIMARY KEY (name);
 J   ALTER TABLE ONLY public.systempropery DROP CONSTRAINT systempropery_pkey;
       public            postgres    false    211            �
           2606    1221956    userinfo userinfo_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public.userinfo
    ADD CONSTRAINT userinfo_pkey PRIMARY KEY (id);
 @   ALTER TABLE ONLY public.userinfo DROP CONSTRAINT userinfo_pkey;
       public            postgres    false    212            L      x������ � �      M   �   x�m�1�0�99����$f*cO�%i��2�Hܞ�BT�ח��$��a��U�µ�VOC�S��fn�ۄW���<9,,zr	)�xJ��\}b+��4D@�x�no�"���Xع Q)��2H-	��l�������´|d�X�2����PA�EXL����簠���Ik���Cd      N   N  x����m�0E�ri�7��j�ŋ�	2��h ݈��ߟ�H�J���gbd"`� ��hȎ�i)��F����g��ٔ���ca��p�RU�l_�*�N������3j�d_���)��">,��b��:dsY8QF�,��ߢ���C6�Ef-��lʢs���!���/G~cȕdȌ
6�v*(�CmP(����Zp��b�MaU_R�0m-D������{�"Y�J![�aĵ���b�1f&lj���8x#�b=Hټ���ޟ���$�5�w�ɦ��d�� ���J��z��["8�Y��|�[6ջМ�k�7�`sY���u��UtȦ_�˲|N%�      O   T   x�KJ�H43�4׵��4�516�еH5)�&�F&�iIɜΉ%���E�
��i�FF&�����
��V&&V��ĸb���� i�j      W   3   x�s�4�050�4��.�44 ��B�]8��@�F\a~.���\1z\\\ נM      Y   �  x�}�ˑ1DϜ(� \ ~� �^�_�!#պj%ʥ�c�1��SW(�H�T��ꋐ��=4��_�,@\~5��$|�q�$��/�uU����"��
���p�Q��"�8��&�pn��J��(�i��P+'p��Kv����̗CJ�3�!���i:�J�8A:*t�D�렡=���06H���D�9N"���vbT���=��lN!��N�ӑ��c͉\�U#u����#�d�c�q�8{j(�#K����\sd�S#�g����P�ذ��^P�q.��ȝ?��E~��ka-�W��@�;�T��uwm<�����"	�a}�u����<4�=5<7�����+��R,%��,����(���|�A9�]!�� �X����p��߀�񑿷q���T�5'&�<+C6��Q-�X�5��Lu��A�!�%:z����O��.�����:�n���丆�,J��F~^��T�cv!�j�WxԮ���u�q�!�      P   ?  x�u�=n�0Fg�� ��$Rs瞠�~��ׯ�"nb���|OT�RG��y�H2� ��f;z���s�䯏��1?Bb�����i"�crg�c�'6��y8h�*�Π�\�҆�16�}�ݧO�?꘍�"�`Wd��lf���ʦ��򨋷J����'�F}(Y�u�� �E�[��lU�hӹ�:�;���r�L�����8è!x� ��\�-o���{��]-'�D�q��9{�Lq�Y
D���;zEW�T�Q7��vD��y��O|Wf�΂����i$/y�s����ݎ�6!�0�3�����1��n      Q     x���Ar!E��)rR���g�FP��8��T�����ᨚ���2�Bh8 ����:�B�(�_�c��tz��-��
pn´�Ǟ#�/��&y�.�9=rAv{�3�	�j�4��jg��9V�
�|C�6NOi�j�6��7�-�]���
�!?��U�I��#���[m����� �:�"k���/����צ؟�K#Qb,փϜG�H�����lS��?��M~+=e��c#C3#��:t�c?��m��UK�B����U�������_9��      R   |  x���K��0D��*z������'���%4�_=��fE%���B�D4�d��A0��9��s�Eq)aC��K@�$�Üm�̨W�]D�XυW�V]	��!z��Oڽ��3��y� ���pt�>�y	��&� �� g5��s_�U$zXs�_ i�A�d]�����ml�b�Q?~iA{�?�[��h@������&�^�[�K�?�9Z����ApY�*���]�I�}o�=(���f�FI��=6��L�ԩ��|VZڬ�*I6.f���v�Yl�K ��5/qt�I-B�<�5��6�f��9�O�ݹ��=�`�QS,�یj.��*?��XG�V�KD��Y#�v���
���(�q�'�������a��      S   �   x���1ND1D��S���؉휂��'N�����-�m�.���yC^C`���
��A�£����}~����X	�%�pf_�*�����;i��i��[��
fN ��e�x�u��1ٍ�!7�_/�ݳ��0�GU
*Ł5d��{����E����K�lZ�
Aب�� jT.o�M6GI�(��L`���^��1r���� (m$"�N�?��P��P��x{9�����      T   �   x�u�1� ��N�8���!����&�T����iӑ����=RI�BG) �`036kh�2�#���X8��Y���{�=럆�ho��4y� Hx���i-e�^.��:M�<mt��`��l��Cl� gEq�*���O���k���a=�      U      x������ � �      V     x����j1�מ��DA�5�d�@Y�@C�Ѝ|�hf������Є
�a[�~�={��40���9b�B1���=-�-����ol�<4�8tD@�"^�֦̏H;��BFJJE�#�Y��e=؛�i[���A6�{<<-+��Y�����Pd_1f��	�6"R��T�3���3;�Cq��\��0 ������3���{R]s}���[2�GY흮K��Rێ��y������W2ʀ�"raΌII�3���7��cvQ[�\��O�:9Q�%�Py7v�<�������b�ϽI�Z�B���jIm�TEG�r허ק��S��}�_�3{��b�NUOb?o�A��.s�[��Ϳ]��-����ŷ�i�~ �ɚ     